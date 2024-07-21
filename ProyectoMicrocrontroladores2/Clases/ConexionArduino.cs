using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMicrocrontroladores2.Clases
{
    internal class ConexionArduino
    {
        private SerialPort puertoSerial;
        private string cadenaConexion;

        public ConexionArduino(string nombrePuerto, int velocidadBaudios, string cadenaConexion)
        {
            puertoSerial = new SerialPort(nombrePuerto, velocidadBaudios);
            puertoSerial.DataReceived += new SerialDataReceivedEventHandler(ManejadorDatosRecibidos);
            this.cadenaConexion = cadenaConexion;
        }

        public void IniciarConexion()
        {
            if (!puertoSerial.IsOpen)
            {
                puertoSerial.Open();
            }
        }

        public void CerrarConexion()
        {
            if (puertoSerial.IsOpen)
            {
                puertoSerial.Close();
            }
        }

        private void ManejadorDatosRecibidos(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string datos = puertoSerial.ReadLine();
                int valorSensor = int.Parse(datos);
                GuardarDatosEnBaseDeDatos(valorSensor);
            }
            catch (Exception ex)
            {
                // Manejar la excepción (opcionalmente puedes registrar errores)
                MessageBox.Show("Error al recibir datos: " + ex.Message);
            }
        }

        private void GuardarDatosEnBaseDeDatos(int valorSensor)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = "INSERT INTO SensorHumedad (HumidityValue) VALUES (@valorSensor)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@valorSensor", valorSensor);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (opcionalmente puedes registrar errores)
                Console.WriteLine("Error al guardar datos en la base de datos: " + ex.Message);
            }
        }
    }
}
