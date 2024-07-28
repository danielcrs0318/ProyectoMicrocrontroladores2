namespace ProyectoMicrocrontroladores2.formularios
{
    partial class FrmDHT11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtHumedad = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChartDHT11 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnConetar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDHT11)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.BackColor = System.Drawing.Color.DarkGray;
            this.lblHumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.ForeColor = System.Drawing.Color.Black;
            this.lblHumedad.Location = new System.Drawing.Point(32, 46);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(67, 16);
            this.lblHumedad.TabIndex = 0;
            this.lblHumedad.Text = "Humedad";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.BackColor = System.Drawing.Color.DarkGray;
            this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(29, 71);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(51, 16);
            this.lblCelsius.TabIndex = 1;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.BackColor = System.Drawing.Color.DarkGray;
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(29, 97);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(70, 16);
            this.lblFahrenheit.TabIndex = 2;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // txtHumedad
            // 
            this.txtHumedad.Location = new System.Drawing.Point(120, 45);
            this.txtHumedad.Name = "txtHumedad";
            this.txtHumedad.Size = new System.Drawing.Size(118, 20);
            this.txtHumedad.TabIndex = 3;
            this.txtHumedad.TextChanged += new System.EventHandler(this.txtHumedad_TextChanged);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(120, 71);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(118, 20);
            this.txtCelsius.TabIndex = 4;
            this.txtCelsius.TextChanged += new System.EventHandler(this.txtCelsius_TextChanged);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(120, 97);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(118, 20);
            this.txtFahrenheit.TabIndex = 5;
            this.txtFahrenheit.TextChanged += new System.EventHandler(this.txtFahrenheit_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 198);
            this.dataGridView1.TabIndex = 6;
            // 
            // ChartDHT11
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartDHT11.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartDHT11.Legends.Add(legend1);
            this.ChartDHT11.Location = new System.Drawing.Point(255, 12);
            this.ChartDHT11.Name = "ChartDHT11";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Humedad";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Celsius";
            this.ChartDHT11.Series.Add(series1);
            this.ChartDHT11.Series.Add(series2);
            this.ChartDHT11.Size = new System.Drawing.Size(371, 144);
            this.ChartDHT11.TabIndex = 7;
            this.ChartDHT11.Text = "chart1";
            // 
            // btnConetar
            // 
            this.btnConetar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnConetar.Location = new System.Drawing.Point(507, 190);
            this.btnConetar.Name = "btnConetar";
            this.btnConetar.Size = new System.Drawing.Size(119, 37);
            this.btnConetar.TabIndex = 8;
            this.btnConetar.Text = "CONECTAR";
            this.btnConetar.UseVisualStyleBackColor = false;
            this.btnConetar.Click += new System.EventHandler(this.btnConetar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnGuardar.Location = new System.Drawing.Point(507, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 37);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnDesconectar.Location = new System.Drawing.Point(507, 278);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(119, 37);
            this.btnDesconectar.TabIndex = 10;
            this.btnDesconectar.Text = "DESCONECTAR";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSalir.Location = new System.Drawing.Point(507, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 37);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(32, 174);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(15, 198);
            this.hScrollBar1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "SensorDHT11";
            // 
            // FrmDHT11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(639, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnConetar);
            this.Controls.Add(this.ChartDHT11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtHumedad);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblHumedad);
            this.Name = "FrmDHT11";
            this.Text = "FrmDHT11";
            this.Load += new System.EventHandler(this.FrmDHT11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDHT11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtHumedad;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDHT11;
        private System.Windows.Forms.Button btnConetar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
    }
}