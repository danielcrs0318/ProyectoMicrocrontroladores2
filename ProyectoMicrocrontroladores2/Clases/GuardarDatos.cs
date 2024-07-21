using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoMicrocrontroladores2.Clases
{
    internal class GuardarDatos
    {
        private string cadenaConexion;
        public int DatoHumedad { get; set; }

        public GuardarDatos(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public void GuardarDatosEnBaseDeDatos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = $"INSERT INTO SensorHumedad (ValorHumedad) VALUES {DatoHumedad}";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("DatoHumedad", DatoHumedad);
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
