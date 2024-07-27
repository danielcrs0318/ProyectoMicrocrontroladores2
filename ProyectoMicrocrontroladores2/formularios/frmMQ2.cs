using System;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProyectoMicrocrontroladores2.Clases;

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class frmMQ2 : Form
    {
        SerialPort Port;
        bool IsClosed = false;
        ClaseConexion dbManager;
        Thread Hilo;

        public frmMQ2()
        {
            InitializeComponent();
            Port = new SerialPort
            {
                PortName = "COM3",
                BaudRate = 9600,
                ReadTimeout = 500
            };

            dateTimePicker1.ValueChanged += new EventHandler(DatePicker_ValueChanged);

            dbManager = new ClaseConexion();


            InitializeChart();
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();
            Series series = new Series
            {
                Name = "EstadoData",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Pie,
                XValueType = ChartValueType.String, // XValueType será el nombre del estado
                YValueType = ChartValueType.Double // YValueType será el porcentaje
            };

            chart1.Series.Add(series);


            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy HH:mm:ss";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisY.Title = "Porcentaje";
            chart1.ChartAreas[0].AxisX.Title = "Estado";

            // Configurar el gráfico para mostrar etiquetas de datos con porcentajes
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "{0:0.00}%"; // Mostrar solo el porcentaje con dos decimales
            series.LabelAngle = 0; // 
            series.LabelBackColor = System.Drawing.Color.White;
            series.LabelForeColor = System.Drawing.Color.Black;
        }

        private void EscucharSerial()
        {
            while (!IsClosed)
            {
                try
                {
                    if (Port.IsOpen)
                    {
                        string cadena = Port.ReadLine();
                        Console.WriteLine($"Datos recibidos: {cadena}");
                        string[] partes = cadena.Split(',');

                        if (partes.Length == 2)
                        {
                            string estado = partes[0];
                            string valor = partes[1];


                            if (txtEstado.InvokeRequired)
                            {
                                txtEstado.Invoke(new Action(() => txtEstado.Text = estado));
                                txtGas.Invoke(new Action(() => txtGas.Text = valor));
                            }
                            else
                            {
                                txtEstado.Text = estado;
                                txtGas.Text = valor;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Datos recibidos en formato incorrecto.");
                        }
                    }
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("Timeout al leer del puerto.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer del puerto: {ex.Message}");
                }
            }
        }

        private void LoadDataGrid()
        {
            DataTable table = dbManager.Query("SELECT * FROM DatosMQ2");
            dataGridView1.DataSource = table;
            UpdateChart();
        }

        private void LoadDataGridByDate(DateTime date)
        {
            string query = $"SELECT * FROM DatosMQ2 WHERE Fecha = '{date:yyyy-MM-dd}'";
            DataTable table = dbManager.Query(query);
            dataGridView1.DataSource = table;
            UpdateChart();
        }

        private void UpdateChart()
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;


            string query = $"SELECT estado, COUNT(*) AS Count FROM DatosMQ2 WHERE Fecha = '{selectedDate:yyyy-MM-dd}' GROUP BY estado";
            DataTable data = dbManager.Query(query);


            var estadoCounts = data.AsEnumerable()
                .GroupBy(row => row.Field<string>("estado"))
                .Select(g => new
                {
                    Estado = g.Key,
                    Count = g.Count()
                })
                .ToList();

            // Calcular el total de registros
            int total = estadoCounts.Sum(e => e.Count);


            chart1.Series["EstadoData"].Points.Clear();


            foreach (var estado in estadoCounts)
            {
                double porcentaje = (double)estado.Count / total * 100;
                chart1.Series["EstadoData"].Points.AddXY(estado.Estado, porcentaje);
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadDataGridByDate(dateTimePicker1.Value.Date);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Port.Open();
                Console.WriteLine("Conexión al puerto serie establecida.");
                IsClosed = false;
                Hilo = new Thread(EscucharSerial)
                {
                    IsBackground = true
                };
                Hilo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el puerto: {ex.Message}");
            }


            LoadDataGrid();
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            IsClosed = true;
            if (Port.IsOpen)
            {
                Port.Close();
                Console.WriteLine("Puerto serie cerrado.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string estado = txtEstado.Text;
            string valor = txtGas.Text;
            if (!string.IsNullOrEmpty(estado) && !string.IsNullOrEmpty(valor))
            {
                string query = $"INSERT INTO DatosMQ2 (estado, valor, Fecha) VALUES ('{estado}', '{valor}', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')";
                if (dbManager.Ejecutar(query))
                {
                    MessageBox.Show("Datos guardados en la base de datos.");
                    UpdateChart();
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para guardar.");
            }
        }

        private void frmMQ2_Load(object sender, EventArgs e)
        {

        }
    }
}