using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMicrocrontroladores2.Clases
{
    public class ClaseDataCO
    {
        private DataTable listaSensorMQ7;


        public ClaseDataCO()
        {
            listaSensorMQ7 = new DataTable();
            ClaseConexion c = new ClaseConexion();
            string sql = $"select sh.IDMQ7 as IDsensor,sh.NivelSensor as NivelCO,sh.Estado as Estado from SensorMQ7 as sh ";
            listaSensorMQ7 = c.Query(sql);
        }

        
        public DataTable ListaSensorMQ7
        {
            get { return listaSensorMQ7; }
        }
    }
    /*internal class ClaseDataCO
    {
    }*/
}
