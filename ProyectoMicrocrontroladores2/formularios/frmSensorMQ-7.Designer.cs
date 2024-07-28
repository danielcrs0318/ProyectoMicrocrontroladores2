namespace ProyectoMicrocrontroladores2.formularios
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMonoxido = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnConectarA = new System.Windows.Forms.Button();
            this.btnGuardarD = new System.Windows.Forms.Button();
            this.btnDesconectarA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonoxido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(269, 82);
            this.txtDatos.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(293, 26);
            this.txtDatos.TabIndex = 7;
            this.txtDatos.TextChanged += new System.EventHandler(this.txtDatos_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Location = new System.Drawing.Point(1046, 3);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(575, 357);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Guardados";
            // 
            // dgvMonoxido
            // 
            this.dgvMonoxido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonoxido.Location = new System.Drawing.Point(20, 33);
            this.dgvMonoxido.Name = "dgvMonoxido";
            this.dgvMonoxido.RowHeadersWidth = 51;
            this.dgvMonoxido.RowTemplate.Height = 24;
            this.dgvMonoxido.Size = new System.Drawing.Size(544, 308);
            this.dgvMonoxido.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "NIVELES DE CO  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "SENSOR DE MONOXIDO DE CARBONO(CO)";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.Maximum = 1000D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(629, 78);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Nivel CO";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(457, 599);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Niveles de CO ";
            title2.Text = "Datos de Sensor MQ-7";
            this.chart1.Titles.Add(title2);
            // 
            // btnConectarA
            // 
            this.btnConectarA.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectarA.Location = new System.Drawing.Point(60, 251);
            this.btnConectarA.Name = "btnConectarA";
            this.btnConectarA.Size = new System.Drawing.Size(132, 68);
            this.btnConectarA.TabIndex = 20;
            this.btnConectarA.Text = "Conectar";
            this.btnConectarA.UseVisualStyleBackColor = true;
            this.btnConectarA.Click += new System.EventHandler(this.btnConectarA_Click);
            // 
            // btnGuardarD
            // 
            this.btnGuardarD.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarD.Location = new System.Drawing.Point(219, 251);
            this.btnGuardarD.Name = "btnGuardarD";
            this.btnGuardarD.Size = new System.Drawing.Size(132, 68);
            this.btnGuardarD.TabIndex = 21;
            this.btnGuardarD.Text = "Guardar";
            this.btnGuardarD.UseVisualStyleBackColor = true;
            this.btnGuardarD.Click += new System.EventHandler(this.btnGuardarD_Click);
            // 
            // btnDesconectarA
            // 
            this.btnDesconectarA.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectarA.Location = new System.Drawing.Point(372, 251);
            this.btnDesconectarA.Name = "btnDesconectarA";
            this.btnDesconectarA.Size = new System.Drawing.Size(175, 68);
            this.btnDesconectarA.TabIndex = 22;
            this.btnDesconectarA.Text = "Desconectar";
            this.btnDesconectarA.UseVisualStyleBackColor = true;
            this.btnDesconectarA.Click += new System.EventHandler(this.btnDesconectarA_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 58);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nivel de CO \r\n<=500 \"Normal\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 52);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nivel de CO \r\n>500 y <=800\"Precaucion\"";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 58);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nivel de CO \r\n>1000 \"Peligro\"";
            // 
            // frmSensorMQ_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1101, 706);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDesconectarA);
            this.Controls.Add(this.btnGuardarD);
            this.Controls.Add(this.btnConectarA);
            this.Controls.Add(this.chart1);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnConectarA;
        private System.Windows.Forms.Button btnGuardarD;
        private System.Windows.Forms.Button btnDesconectarA;
        private System.Windows.Forms.DataGridView dgvMonoxido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}