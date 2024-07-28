using System;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Importar espacio de nombres para el control Chart
using System.Data.SqlClient; // Importar espacio de nombres para SqlConnection
using ProyectoMicrocrontroladores2.Clases;

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class frmMQ2 : Form
    {
        SerialPort Port;
        bool IsClosed = false;
        DatabaseManager dbManager;
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

            // Configurar la conexión a la base de datos
            string base_datos = "proyectoMicrocontroladores";
            string Servidor = "localhost";
            string usuarioDB = "Microcontroladores";
            string contrasena = "1234";
            string connectionString = $"Server={Servidor};Database={base_datos};User Id={usuarioDB};Password={contrasena};";
            dbManager = new DatabaseManager(connectionString);

            // Suscribirse al evento DataUpdated para actualizar el DataGridView
            dbManager.DataUpdated += UpdateDataGrid;

            // Inicializar el gráfico
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

            // Configurar el área del gráfico
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy HH:mm:ss";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisY.Title = "Porcentaje";
            chart1.ChartAreas[0].AxisX.Title = "Estado";

            // Configurar el gráfico para mostrar etiquetas de datos con porcentajes
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "{0:0.00}%"; // Mostrar solo el porcentaje con dos decimales
            series.LabelAngle = 0; // Ajustar el ángulo de las etiquetas si es necesario
            series.LabelBackColor = System.Drawing.Color.White; // Fondo blanco para mejor visibilidad
            series.LabelForeColor = System.Drawing.Color.Black; // Color de texto negro
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
                        Console.WriteLine($"Datos recibidos: {cadena}"); // Mensaje de depuración
                        string[] partes = cadena.Split(',');

                        if (partes.Length == 2)
                        {
                            string estado = partes[0];
                            string valor = partes[1];

                            // Asegúrate de usar Invoke para actualizar los controles desde el hilo de la interfaz de usuario
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
            DataTable table = dbManager.LoadData();
            dataGridView1.DataSource = table;
            UpdateChart(); // Actualizar el gráfico
        }

        private void UpdateDataGrid()
        {
            // Este método será llamado cuando se actualicen los datos
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action(() => LoadDataGrid()));
            }
            else
            {
                LoadDataGrid();
            }
        }

        private void LoadDataGridByDate(DateTime date)
        {
            DataTable table = dbManager.LoadDataByDate(date);
            dataGridView1.DataSource = table;
            UpdateChart(); // Actualizar el gráfico
        }

        private void UpdateChart()
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Filtrar los datos para la fecha seleccionada
            DataTable data = dbManager.LoadDataByDate(selectedDate);

            // Agrupar los datos por estado y contar las ocurrencias
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

            // Limpiar puntos del gráfico
            chart1.Series["EstadoData"].Points.Clear();

            // Agregar puntos al gráfico de pastel
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

            // Inicialmente, cargar datos en el DataGridView
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
            // Llama a un método que guarda los datos actuales en la base de datos
            string estado = txtEstado.Text;
            string valor = txtGas.Text;
            if (!string.IsNullOrEmpty(estado) && !string.IsNullOrEmpty(valor))
            {
                dbManager.SaveData(estado, valor);
                MessageBox.Show("Datos guardados en la base de datos.");
                UpdateChart(); // Actualizar el gráfico después de guardar
            }
            else
            {
                MessageBox.Show("No hay datos para guardar.");
            }
        }
    }
}
