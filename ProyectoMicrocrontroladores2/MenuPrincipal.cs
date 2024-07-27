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
        private ClaseConexion conexion;
        public MenuPrincipal()
        {
            InitializeComponent();
            conexion = new ClaseConexion();
            conexion.Conectar();
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

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmSensorMQ_7 frmSensorMQ_7 = new frmSensorMQ_7();
            frmSensorMQ_7.MdiParent = this;
            frmSensorMQ_7.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
