using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using ProyectoMicrocrontroladores2.Clases;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class frmSensorHumedadSuelo : Form
    {
        private GuardarDatos guardarDatos;
        private SerialPort _serialPort;
        

        public frmSensorHumedadSuelo()
        {
            InitializeComponent();
            guardarDatos = new GuardarDatos();
            InitializeChart();
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();
            Series series = new Series("ArduinoData")
            {
                ChartType = SeriesChartType.Line
            };
            chart1.Series.Add(series);
        }

        private void UpdateChart(string data)
        {
            if (double.TryParse(data, out double value))
            {
                chart1.Series["ArduinoData"].Points.AddY(value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmSensorHumedadSuelo_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort("COM3", 9600);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNCONECTAR_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                    MessageBox.Show("Conectado al Arduino.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}");
            }
        }

        private void BTNDESCONECTAR_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                MessageBox.Show("Desconectado del Arduino.");
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _serialPort.ReadLine();
                // Usar Invoke para actualizar el TextBox en el hilo principal
                this.Invoke(new MethodInvoker(delegate {
                    cuadroTextoDatos.AppendText(data + Environment.NewLine);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recibir datos: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardarDatos.Guardar();
        }

        private void cuadroTextoDatos_TextChanged(object sender, EventArgs e)
        {
            if (cuadroTextoDatos.Text == string.Empty)
            {
                guardarDatos.DatoHumedad = Convert.ToInt32(cuadroTextoDatos.Text);
            }
        }
    }
}
