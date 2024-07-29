﻿using ProyectoMicrocrontroladores2.Clases;
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

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            FrmDHT11 frmDHT11 = new FrmDHT11();
            frmDHT11.MdiParent = this;
            frmDHT11.Show();
        }
    }
}
