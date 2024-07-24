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

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class frmSensorMQ_7 : Form
    {
        private ClaseSensorMQ7 ClaseSensorMQ7;
        private SerialPort _serialPort;

        private DataTable data;
        public frmSensorMQ_7()
        {
            InitializeComponent();
            ClaseSensorMQ7 = new ClaseSensorMQ7();

            Datagrid le = new Datagrid();
            dgvMonoxido.DataSource = le.ListaSensorHumedadSuelo;
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

        private void BTNCONECTAR_Click(object sender, EventArgs e)
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
                    txtDatos.AppendText(data + Environment.NewLine);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recibir datos: {ex.Message}");
            }
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
    }
}
