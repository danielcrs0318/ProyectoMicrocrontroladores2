namespace ProyectoMicrocrontroladores2.formularios
{
    partial class FormInfrarrojo
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
            this.label1 = new System.Windows.Forms.Label();
            this.DATOSINFRA = new System.Windows.Forms.Label();
            this.DATOSSERVO = new System.Windows.Forms.Label();
            this.DATOSCOLOR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNINICIAR = new System.Windows.Forms.Button();
            this.BTNAPAGAR = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNCONSULTAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Infrarrojo con Servomotor";
            // 
            // DATOSINFRA
            // 
            this.DATOSINFRA.AutoSize = true;
            this.DATOSINFRA.BackColor = System.Drawing.Color.White;
            this.DATOSINFRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATOSINFRA.Location = new System.Drawing.Point(336, 129);
            this.DATOSINFRA.Name = "DATOSINFRA";
            this.DATOSINFRA.Size = new System.Drawing.Size(30, 32);
            this.DATOSINFRA.TabIndex = 1;
            this.DATOSINFRA.Text = "0";
            // 
            // DATOSSERVO
            // 
            this.DATOSSERVO.AutoSize = true;
            this.DATOSSERVO.BackColor = System.Drawing.Color.White;
            this.DATOSSERVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATOSSERVO.Location = new System.Drawing.Point(336, 247);
            this.DATOSSERVO.Name = "DATOSSERVO";
            this.DATOSSERVO.Size = new System.Drawing.Size(30, 32);
            this.DATOSSERVO.TabIndex = 2;
            this.DATOSSERVO.Text = "0";
            // 
            // DATOSCOLOR
            // 
            this.DATOSCOLOR.AutoSize = true;
            this.DATOSCOLOR.BackColor = System.Drawing.Color.White;
            this.DATOSCOLOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATOSCOLOR.Location = new System.Drawing.Point(336, 183);
            this.DATOSCOLOR.Name = "DATOSCOLOR";
            this.DATOSCOLOR.Size = new System.Drawing.Size(30, 32);
            this.DATOSCOLOR.TabIndex = 3;
            this.DATOSCOLOR.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Infrarrojo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Color Detectado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Grados Servomotor";
            // 
            // BTNINICIAR
            // 
            this.BTNINICIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINICIAR.Location = new System.Drawing.Point(251, 326);
            this.BTNINICIAR.Name = "BTNINICIAR";
            this.BTNINICIAR.Size = new System.Drawing.Size(138, 46);
            this.BTNINICIAR.TabIndex = 7;
            this.BTNINICIAR.Text = "Iniciar";
            this.BTNINICIAR.UseVisualStyleBackColor = true;
            this.BTNINICIAR.Click += new System.EventHandler(this.BTNINICIAR_Click);
            // 
            // BTNAPAGAR
            // 
            this.BTNAPAGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAPAGAR.Location = new System.Drawing.Point(65, 326);
            this.BTNAPAGAR.Name = "BTNAPAGAR";
            this.BTNAPAGAR.Size = new System.Drawing.Size(138, 46);
            this.BTNAPAGAR.TabIndex = 8;
            this.BTNAPAGAR.Text = "Apagar";
            this.BTNAPAGAR.UseVisualStyleBackColor = true;
            this.BTNAPAGAR.Click += new System.EventHandler(this.BTNAPAGAR_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(688, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(720, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "Consulta Datos";
            // 
            // BTNCONSULTAR
            // 
            this.BTNCONSULTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCONSULTAR.Location = new System.Drawing.Point(757, 183);
            this.BTNCONSULTAR.Name = "BTNCONSULTAR";
            this.BTNCONSULTAR.Size = new System.Drawing.Size(138, 46);
            this.BTNCONSULTAR.TabIndex = 11;
            this.BTNCONSULTAR.Text = "Consultar";
            this.BTNCONSULTAR.UseVisualStyleBackColor = true;
            this.BTNCONSULTAR.Click += new System.EventHandler(this.BTNCONSULTAR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 213);
            this.dataGridView1.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(627, 247);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(700, 401);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // FormInfrarrojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1381, 673);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNCONSULTAR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BTNAPAGAR);
            this.Controls.Add(this.BTNINICIAR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DATOSCOLOR);
            this.Controls.Add(this.DATOSSERVO);
            this.Controls.Add(this.DATOSINFRA);
            this.Controls.Add(this.label1);
            this.Name = "FormInfrarrojo";
            this.Text = "FormInfrarrojo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInfrarrojo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DATOSINFRA;
        private System.Windows.Forms.Label DATOSSERVO;
        private System.Windows.Forms.Label DATOSCOLOR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTNINICIAR;
        private System.Windows.Forms.Button BTNAPAGAR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNCONSULTAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}