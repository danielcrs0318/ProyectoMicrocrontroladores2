using System;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProyectoMicrocrontroladores2.Clases;

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class FrmMQ2 : Form
    {
        SerialPort Port;
        bool IsClosed = false;
        ClaseConexion dbConnection;
        Thread Hilo;

        public FrmMQ2()
        {
            InitializeComponent();
            Port = new SerialPort
            {
                PortName = "COM3",
                BaudRate = 9600,
                ReadTimeout = 500
            };

            dateTimePicker1.ValueChanged += new EventHandler(DatePicker_ValueChanged);

            dbConnection = new ClaseConexion();

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

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy HH:mm:ss";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisY.Title = "Porcentaje";
            chart1.ChartAreas[0].AxisX.Title = "Estado";

            series.IsValueShownAsLabel = true;
            series.LabelFormat = "{0:0.00}%";
            series.LabelAngle = 0;
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
                        MessageBox.Show($"Datos recibidos: {cadena}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Datos recibidos en formato incorrecto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Timeout al leer del puerto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer del puerto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDataGrid()
        {
            DataTable table = dbConnection.Query("SELECT * FROM DatosMQ2");
            dataGridView1.DataSource = table;
            UpdateChart();
        }

        private void UpdateDataGrid()
        {
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
            string query = $"SELECT * FROM DatosMQ2 WHERE Fecha = '{date:yyyy-MM-dd}'";
            DataTable table = dbConnection.Query(query);
            dataGridView1.DataSource = table;
            UpdateChart();
        }

        private void UpdateChart()
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            string query = $"SELECT * FROM DatosMQ2 WHERE Fecha = '{selectedDate:yyyy-MM-dd}'";
            DataTable data = dbConnection.Query(query);

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
            // Verifica si el puerto ya está abierto
            if (Port.IsOpen)
            {
                MessageBox.Show("El puerto ya está abierto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Intenta abrir el puerto serie
                Port.Open();
                MessageBox.Show("Conexión al puerto serie establecida.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Configura la bandera para indicar que el puerto no está cerrado
                IsClosed = false;

                // Verifica si el hilo ya ha sido creado y está en ejecución
                if (Hilo == null || !Hilo.IsAlive)
                {
                    Hilo = new Thread(EscucharSerial)
                    {
                        IsBackground = true
                    };
                    Hilo.Start();
                    MessageBox.Show("Hilo de escucha iniciado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El hilo de escucha ya está en ejecución.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                // Maneja excepciones de acceso denegado
                MessageBox.Show($"Acceso denegado al puerto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                // Maneja excepciones de entrada/salida
                MessageBox.Show($"Error de entrada/salida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                // Maneja excepciones de argumentos inválidos
                MessageBox.Show($"Argumento inválido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Maneja cualquier otra excepción
                MessageBox.Show($"Error al abrir el puerto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Puerto serie cerrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string estado = txtEstado.Text;
            string valor = txtGas.Text;
            if (!string.IsNullOrEmpty(estado) && !string.IsNullOrEmpty(valor))
            {
                string query = $"INSERT INTO DatosMQ2 (estado, valor, fecha) VALUES ('{estado}', '{valor}', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')";
                if (dbConnection.Ejecutar(query))
                {
                    MessageBox.Show("Datos guardados en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateChart();
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
