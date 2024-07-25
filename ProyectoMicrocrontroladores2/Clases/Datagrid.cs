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
        private DataTable listaSensorDHT11;


        public Datagrid()
        {
            listaSensorHumedad = new DataTable();
            ClaseConexion c = new ClaseConexion();
            string sql = $"select sh.IdSensor as IDSENSOR,sh.ValorHumedad as HUMEDADSUELO, sh.fecha as FECHA from SensorHumedad as sh ";
            listaSensorHumedad = c.Query(sql);

            listaSensorDHT11 = new DataTable();
            ClaseConexion cDHT11 = new ClaseConexion();
            string sqlDHT11 = "SELECT id AS ID, Humedad AS HUMEDAD, Celsius AS TEMPERATURA_C, Fahrenheit AS TEMPERATURA_F, Timestamp AS FECHA FROM SensorData";
            listaSensorDHT11 = cDHT11.Query(sqlDHT11);


        }

        public DataTable ListaSensorHumedadSuelo
        {
            get { return listaSensorHumedad; }
        }
        public DataTable ListaSensorDHT11
        {
            get { return listaSensorDHT11; }
        }
    }
}
