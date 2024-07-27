using ProyectoMicrocrontroladores2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        //boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatosDHT11.GuardarDHT11();
        }
        //boton Conectar
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                MessageBox.Show("Desconectado del Arduino.");
            }
        }
        //txtHumedad
        private void txtHumedad_TextChanged(object sender, EventArgs e)
        {
            if (txtHumedad.Text != string.Empty)
            {
                GuardarDatosDHT11.DatoHumedad = Convert.ToDouble(txtHumedad);
            }
        }
        //txtcelsius
        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            if (txtCelsius.Text != string.Empty)
            {
                GuardarDatosDHT11.DatoCelsius = Convert.ToDouble(txtCelsius);
            }
        }

        //txtfahrenheit
        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (txtFahrenheit.Text != string.Empty)
            {
                GuardarDatosDHT11.DatoFahrenheit = Convert.ToDouble(txtFahrenheit);
            }

        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string datos = _serialPort.ReadLine();
                string[] valores = datos.Split(':');
                if (valores.Length == 3)
                {
                    double humedad = double.Parse(valores[0]);
                    double celsius = double.Parse(valores[1]);
                    double fahrenheit = double.Parse(valores[2]);

                    Invoke(new Action(() =>
                    {
                        txtHumedad.Text = humedad.ToString();
                        txtCelsius.Text = celsius.ToString();
                        txtFahrenheit.Text = fahrenheit.ToString();
                    }));

                    GuardarDatosDHT11 guardarDHT11 = new GuardarDatosDHT11();
                    // Guardar los datos en la base de datos
                    guardarDHT11.GuardarDHT11();

                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (opcionalmente puedes registrar errores)
                MessageBox.Show("Error al recibir datos: " + ex.Message);
            }
        }
        //ELIMINA PROBLEMAS DE SERIALPORTdaTARECEIVED
        private void SerialPort_DataReceived(double humedad, double celsius, double fahrenheit)
        {
            throw new NotImplementedException();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FrmDHT11_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort("COM3", 9600);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
        }
        /* NO USAR
        private void GuardarDatosBBDdht(double humedad, double celsius, double fahrenheit)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion))
                {
                    string consulta = "INSERT INTO SensorData (Humedad, Celsius, Fahrenheit) VALUES (@humedad, @celsius, @fahrenheit)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@humedad", humedad);
                        comando.Parameters.AddWithValue("@celsius", celsius);
                        comando.Parameters.AddWithValue("@fahrenheit", fahrenheit);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (opcionalmente puedes registrar errores)
                MessageBox.Show("Error al guardar datos en la base de datos: " + ex.Message);
            }
        }

        */

    }
}
