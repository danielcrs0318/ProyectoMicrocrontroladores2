﻿namespace ProyectoMicrocrontroladores2.formularios
{
    partial class frmSensorMQ_7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSensorMQ_7));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BTNDESCONECTAR = new System.Windows.Forms.Button();
            this.BTNCONECTAR = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMonoxido = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonoxido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(235, 162);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 53);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BTNDESCONECTAR
            // 
            this.BTNDESCONECTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDESCONECTAR.Location = new System.Drawing.Point(403, 162);
            this.BTNDESCONECTAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDESCONECTAR.Name = "BTNDESCONECTAR";
            this.BTNDESCONECTAR.Size = new System.Drawing.Size(180, 53);
            this.BTNDESCONECTAR.TabIndex = 17;
            this.BTNDESCONECTAR.Text = "DESCONECTAR";
            this.BTNDESCONECTAR.UseVisualStyleBackColor = true;
            this.BTNDESCONECTAR.Click += new System.EventHandler(this.BTNDESCONECTAR_Click);
            // 
            // BTNCONECTAR
            // 
            this.BTNCONECTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCONECTAR.Location = new System.Drawing.Point(67, 162);
            this.BTNCONECTAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCONECTAR.Name = "BTNCONECTAR";
            this.BTNCONECTAR.Size = new System.Drawing.Size(141, 53);
            this.BTNCONECTAR.TabIndex = 16;
            this.BTNCONECTAR.Text = "CONECTAR";
            this.BTNCONECTAR.UseVisualStyleBackColor = true;
            this.BTNCONECTAR.Click += new System.EventHandler(this.BTNCONECTAR_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(336, 110);
            this.txtDatos.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(293, 26);
            this.txtDatos.TabIndex = 15;
            this.txtDatos.TextChanged += new System.EventHandler(this.txtDatos_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Location = new System.Drawing.Point(609, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 39);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMonoxido);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 240);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(575, 357);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Guardados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "NIVELES DE CO - ESTADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "SENSOR DE MONOXIDO DE CARBONO(CO)";
            // 
            // dgvMonoxido
            // 
            this.dgvMonoxido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonoxido.Location = new System.Drawing.Point(11, 30);
            this.dgvMonoxido.Name = "dgvMonoxido";
            this.dgvMonoxido.RowHeadersWidth = 51;
            this.dgvMonoxido.RowTemplate.Height = 24;
            this.dgvMonoxido.Size = new System.Drawing.Size(545, 311);
            this.dgvMonoxido.TabIndex = 0;
            // 
            // frmSensorMQ_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(662, 651);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BTNDESCONECTAR);
            this.Controls.Add(this.BTNCONECTAR);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSensorMQ_7";
            this.Text = "frmSensorMQ_7";
            this.Load += new System.EventHandler(this.frmSensorMQ_7_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonoxido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BTNDESCONECTAR;
        private System.Windows.Forms.Button BTNCONECTAR;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMonoxido;
    }
}