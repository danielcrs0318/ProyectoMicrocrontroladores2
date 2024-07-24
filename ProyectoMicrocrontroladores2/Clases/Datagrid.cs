using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMicrocrontroladores2.Clases
{
    public class Datagrid
    {
        private DataTable listaSensorHumedad;
        private DataTable listaSensorMQ7;
       

        public Datagrid()
        {
            listaSensorHumedad = new DataTable();
            ClaseConexion c = new ClaseConexion();
            string sql = $"select sh.IdSensor as IDSENSOR,sh.ValorHumedad as HUMEDADSUELO, sh.fecha as FECHA from SensorHumedad as sh ";
            listaSensorHumedad = c.Query(sql);
        }

        public DataTable ListaSensorHumedadSuelo
        {
            get { return listaSensorHumedad; }
        }
        public DataTable ListaSensorMQ7
        {
            get { return listaSensorMQ7; }
        }
    }
}
