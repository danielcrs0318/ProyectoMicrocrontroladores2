using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace ProyectoMicrocrontroladores2.Clases
{
    internal class ClaseConexion
    {
        private SqlConnection conexion;
        private String base_datos;
        private String Servidor;
        private String usuarioDB;
        private String contrasena;

        public ClaseConexion()
        {
            conexion = new SqlConnection();
            base_datos = "proyectoMicrocontroladores";
            Servidor = "localhost";
            usuarioDB = "Microcontroladores";
            contrasena = "1234";
            conexion.ConnectionString = "Server=" + Servidor + ";Database=" +
                base_datos + ";User Id=" + usuarioDB + ";Password=" + contrasena + ";";
        }

        public void Conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                try
                {
                    conexion.Open();
                    //MessageBox.Show("Conexion establecida correctamente");
                }
                catch (SqlException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                try
                {
                    conexion.Close();
                    conexion.Open();
                    MessageBox.Show("Conexion establecida correctamente");

                }
                catch (SqlException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        public DataTable Query(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conexion);
            Conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public Boolean Ejecutar(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                Conectar();
                cmd.ExecuteReader();
                return true;
            }
            catch (SqlException er)
            {
                MessageBox.Show(er.ToString());
                return false;
            }
        }
    
    }
}
