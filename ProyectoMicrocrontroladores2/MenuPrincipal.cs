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
        public MenuPrincipal()
        {
            InitializeComponent();
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

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FormInfrarrojo form = new FormInfrarrojo();
            form.MdiParent = this;
            form.Show();
        }
    }
}
