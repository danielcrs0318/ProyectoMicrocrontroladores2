namespace ProyectoMicrocrontroladores2.formularios
{
    partial class frmSensorHumedadSuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSensorHumedadSuelo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHumedadSuelo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cuadroTextoDatos = new System.Windows.Forms.TextBox();
            this.BTNCONECTAR = new System.Windows.Forms.Button();
            this.BTNDESCONECTAR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHumedadSuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SENSOR DE HUMEDAD DE SUELO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Humedad del Suelo %:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHumedadSuelo);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 236);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(575, 357);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Guardados";
            // 
            // dgvHumedadSuelo
            // 
            this.dgvHumedadSuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHumedadSuelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHumedadSuelo.Location = new System.Drawing.Point(4, 26);
            this.dgvHumedadSuelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHumedadSuelo.Name = "dgvHumedadSuelo";
            this.dgvHumedadSuelo.RowHeadersWidth = 51;
            this.dgvHumedadSuelo.Size = new System.Drawing.Size(567, 327);
            this.dgvHumedadSuelo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(568, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 39);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuadroTextoDatos
            // 
            this.cuadroTextoDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroTextoDatos.Location = new System.Drawing.Point(299, 107);
            this.cuadroTextoDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuadroTextoDatos.Name = "cuadroTextoDatos";
            this.cuadroTextoDatos.Size = new System.Drawing.Size(257, 26);
            this.cuadroTextoDatos.TabIndex = 7;
            this.cuadroTextoDatos.TextChanged += new System.EventHandler(this.cuadroTextoDatos_TextChanged);
            // 
            // BTNCONECTAR
            // 
            this.BTNCONECTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCONECTAR.Location = new System.Drawing.Point(71, 158);
            this.BTNCONECTAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNCONECTAR.Name = "BTNCONECTAR";
            this.BTNCONECTAR.Size = new System.Drawing.Size(141, 53);
            this.BTNCONECTAR.TabIndex = 8;
            this.BTNCONECTAR.Text = "CONECTAR";
            this.BTNCONECTAR.UseVisualStyleBackColor = true;
            this.BTNCONECTAR.Click += new System.EventHandler(this.BTNCONECTAR_Click_1);
            // 
            // BTNDESCONECTAR
            // 
            this.BTNDESCONECTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDESCONECTAR.Location = new System.Drawing.Point(407, 158);
            this.BTNDESCONECTAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNDESCONECTAR.Name = "BTNDESCONECTAR";
            this.BTNDESCONECTAR.Size = new System.Drawing.Size(180, 53);
            this.BTNDESCONECTAR.TabIndex = 9;
            this.BTNDESCONECTAR.Text = "DESCONECTAR";
            this.BTNDESCONECTAR.UseVisualStyleBackColor = true;
            this.BTNDESCONECTAR.Click += new System.EventHandler(this.BTNDESCONECTAR_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(239, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "GUARDAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSensorHumedadSuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(607, 606);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTNDESCONECTAR);
            this.Controls.Add(this.BTNCONECTAR);
            this.Controls.Add(this.cuadroTextoDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSensorHumedadSuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sensor Humedad de Suelo";
            this.Load += new System.EventHandler(this.frmSensorHumedadSuelo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHumedadSuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHumedadSuelo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cuadroTextoDatos;
        private System.Windows.Forms.Button BTNCONECTAR;
        private System.Windows.Forms.Button BTNDESCONECTAR;
        private System.Windows.Forms.Button button2;
    }
}