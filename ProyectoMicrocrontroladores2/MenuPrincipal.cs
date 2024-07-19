using ProyectoMicrocrontroladores2.Clases;
using ProyectoMicrocrontroladores2.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMicrocrontroladores2
{
    public partial class MenuPrincipal : Form

    {
        private ConexionArduino arduinoConnection;
        public MenuPrincipal()
        {
            InitializeComponent();
            string cadenaConexion = "Server=localhost;Database=NombreBaseDatos;User Id=Usuario;Password=Contraseña;";
            arduinoConnection = new ConexionArduino("COM3", 9600, cadenaConexion); // Cambia "COM3" por el puerto que esté usando tu Arduino
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
        }

        private void sENSORHUMEDADDESUELOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSensorHumedadSuelo sensorhumedadsuelo = new frmSensorHumedadSuelo();
            sensorhumedadsuelo.MdiParent = this;
            sensorhumedadsuelo.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmSensorHumedadSuelo frmsensorhumedad = new frmSensorHumedadSuelo();
            frmsensorhumedad.MdiParent = this;
            frmsensorhumedad.Show();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            arduinoConnection.IniciarConexion();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduinoConnection.CerrarConexion();
        }
    }
}
