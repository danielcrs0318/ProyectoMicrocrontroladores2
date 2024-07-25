using ProyectoMicrocrontroladores2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class FrmDHT11 : Form
    {

        private GuardarDatosDHT11 GuardarDatosDHT11;
        private SerialPort _serialPort;
        public FrmDHT11()
        {
            InitializeComponent();
            GuardarDatosDHT11 = new GuardarDatosDHT11();
            InitializeChart();

        }

        private void btnConetar_Click(object sender, EventArgs e)
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

        private void InitializeChart() 
        {
            //
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //guardarDatosDHT11.Guardar();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                MessageBox.Show("Desconectado del Arduino.");
            }
        }
    }
}
