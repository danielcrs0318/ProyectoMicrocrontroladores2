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

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class frmSensorHumedadSuelo : Form
    {
        public frmSensorHumedadSuelo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmSensorHumedadSuelo_Load(object sender, EventArgs e)
        {

        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            
        }
     
    }
}
