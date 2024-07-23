using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace ProyectoMicrocrontroladores2.Clases
{
    internal class GuardarDatos
    {
        public int DatoHumedad { get; set; }


        public GuardarDatos()
        {
            DatoHumedad = 0;
        }

        public GuardarDatos(int dato)
        {
            DatoHumedad = dato; 
        }
        //metodo para que guarde los datos en la bdd
        public void Guardar()
        {
            //validamos si el campo esta vacio 
            if (DatoHumedad == 0)
            {
                MessageBox.Show("No hay Dato de Humedad");
            }
            else
            {
                string sql = $"insert into SensorHumedad(ValorHumedad)" +
                    $"values ({DatoHumedad});";
                ClaseConexion c = new ClaseConexion();
                if (c.Ejecutar(sql))
                {
                    MessageBox.Show("Registro Guardado");
                }
                else
                {
                    MessageBox.Show("Error al guardar el registro");
                }
            }

        }
    }
}
