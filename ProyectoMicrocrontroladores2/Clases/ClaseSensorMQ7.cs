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

    internal class ClaseSensorMQ7
    {
        public int DatoCO {  get; set; }


        public ClaseSensorMQ7() 
        { 
           DatoCO = 0;
        }

        public ClaseSensorMQ7(int Dato)
        {
            DatoCO = Dato;
        }
        public void Guardar()
        {
            //validamos si el campo esta vacio 
            if (DatoCO == 0)
            {
                MessageBox.Show("No hay Datos de CO");
            }
            else
            {
                string sql = $"insert into SensorMQ7(NivelSensor)" +
                    $"values ({DatoCO});";
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
