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
    public partial class frmSensorMQ_7 : Form
    {
        private ClaseSensorMQ7 ClaseSensorMQ7;
        private SerialPort _serialPort;
        private ClaseDataCO ClaseDataCO;

        private DataTable data;
        public frmSensorMQ_7()
        {
            InitializeComponent();
            ClaseSensorMQ7 = new ClaseSensorMQ7();
            InitializeChart();
            ClaseDataCO le = new ClaseDataCO();
            dgvMonoxido.DataSource = le.ListaSensorMQ7;
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

        private void frmSensorMQ_7_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort("COM3", 9600);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void BTNCONECTAR_Click(object sender, EventArgs e)
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
        }*/

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _serialPort.ReadLine();
                // Usar Invoke para actualizar el TextBox en el hilo principal
                this.Invoke(new MethodInvoker(delegate {
                    txtDatos.Text = data;
                    txtDatosEstado.Text = data;
                    UpdateChart(data);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recibir datos: {ex.Message}");
            }
        }
        /*private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = _serialPort.ReadLine();
            this.Invoke(new MethodInvoker(delegate
            {
                
            }));
        }*/
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _serialPort.Close();
            base.OnFormClosing(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClaseSensorMQ7.Guardar();
        }

        private void txtDatos_TextChanged(object sender, EventArgs e)
        {
            if(txtDatos.Text != string.Empty)
            {
                ClaseSensorMQ7.DatoCO = Convert.ToInt32(txtDatos.Text);
            }
        }

        private void dgvMonoxido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConectarA_Click(object sender, EventArgs e)
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

        private void btnDesconectarA_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                MessageBox.Show("Desconectado del Arduino.");
            }
        }

        private void btnGuardarD_Click(object sender, EventArgs e)
        {
            ClaseSensorMQ7.Guardar();
            ClaseDataCO dgv = new ClaseDataCO();
            dgvMonoxido.DataSource = dgv.ListaSensorMQ7;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDatosEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtDatosEstado.Text != string.Empty)
            {
                ClaseSensorMQ7.DatoCO = Convert.ToInt32(txtDatosEstado.Text);
            }
        }
    }
}
