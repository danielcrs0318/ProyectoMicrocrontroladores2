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
using ProyectoMicrocrontroladores2.Clases;

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class frmSensorHumedadSuelo : Form
    {
        private GuardarDatos guardarDatos;
        public frmSensorHumedadSuelo()
        {
            InitializeComponent();
            string cadenaConexion = "Server=localhost;Database=proyectoMicrocontroladores;User Id=Usuario;Password=Contraseña;";
            guardarDatos = new GuardarDatos(cadenaConexion);
            this.Load += new EventHandler(frmSensorHumedadSuelo_Load);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmSensorHumedadSuelo_Load(object sender, EventArgs e)
        {
            guardarDatos.GuardarDatosEnBaseDeDatos();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            
        }
     
    }
}
