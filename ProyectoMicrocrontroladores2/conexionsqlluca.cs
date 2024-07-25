using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMicrocrontroladores2
{
    internal class conexionsqlluca
    {

        private SqlConnection conexion;
        private String DATABASE;
        private String Servidor;
        private String usuario;
        private String contrasena;

        public conexionsqlluca()
        {

            DATABASE = "proyectoMicrocontroladores";
            Servidor = "localhost";
            usuario = "Microcontroladores";
            contrasena = "1234";
            string connectionString = $"Server={Servidor};Database={DATABASE};User Id={usuario};Password={contrasena};";
            conexion = new SqlConnection(connectionString);


        }

        public void Conectar()
        {
            //if (conexion.State == ConnectionState.Closed)
            //{
            try
            {


                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    //MessageBox.Show("Conexión establecida");
                }
            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }
            //}
            //else
            //{
            //    try
            //    {
            //        conexion.Close();
            //        conexion.Open();
            //        //MessageBox.Show("Conexion establecida correctamente");

            //    }
            //    catch (SqlException er)
            //    {
            //        MessageBox.Show(er.Message);
            //    }
            //}

        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
                //MessageBox.Show("Conexión cerrada");
            }
        }

        public DataTable Query(string query)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand(query, conexion);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public Boolean Ejecutar(string query)
        {
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException er)
            {
                MessageBox.Show(er.ToString());
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }


    }
}
