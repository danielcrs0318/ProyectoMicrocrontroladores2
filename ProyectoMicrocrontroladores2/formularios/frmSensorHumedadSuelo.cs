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

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class frmSensorHumedadSuelo : Form
    {
        private SerialPort puertoSerial;
        public frmSensorHumedadSuelo()
        {
            InitializeComponent();
            puertoSerial = new SerialPort("COM3", 9600); // Cambia "COM3" por el puerto que esté usando tu Arduino
            puertoSerial.DataReceived += new SerialDataReceivedEventHandler(ManejadorDatosRecibidos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmSensorHumedadSuelo_Load(object sender, EventArgs e)
        {

        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            if (!puertoSerial.IsOpen)
            {
                puertoSerial.Open();
            }
        }
        private void ManejadorDatosRecibidos(object sender, SerialDataReceivedEventArgs e)
        {
            string datos = puertoSerial.ReadLine();
            this.Invoke(new Action(() => {
                cuadroTextoDatos.Text =datos;
                //GuardarDatosEnBaseDeDatos(int.Parse(
                //datos));
            }));
        }

        /*private void GuardarDatosEnBaseDeDatos(int valorSensor)
        {
            string cadenaConexion = "Server=localhost;Database=proyectoMicrocontroladores;Trusted_Connection=True;";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "INSERT INTO SensorHumedad (ValorHumedad) VALUES (@valorSensor)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@valorSensor", valorSensor);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }*/
    }
}
