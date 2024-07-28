using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProyectoMicrocrontroladores2.Clases;

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class frmMQ2 : Form
    {
        private ClaseMQ2 mq2Manager;

        public frmMQ2()
        {
            InitializeComponent();
            mq2Manager = new ClaseMQ2();
            dateTimePicker1.ValueChanged += new EventHandler(DatePicker_ValueChanged);
            InitializeChart();
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();
            Series series = new Series
            {
                Name = "EstadoData",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Pie,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy HH:mm:ss";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisY.Title = "Porcentaje";
            chart1.ChartAreas[0].AxisX.Title = "Estado";

            series.IsValueShownAsLabel = true;
            series.LabelFormat = "{0:0.00}%";
            series.LabelAngle = 0;
            series.LabelBackColor = System.Drawing.Color.White;
            series.LabelForeColor = System.Drawing.Color.Black;
        }

        private void LoadDataGrid()
        {
            DataTable table = mq2Manager.GetAllData();
            dataGridView1.DataSource = table;
            UpdateChart();
        }

        private void LoadDataGridByDate(DateTime date)
        {
            DataTable table = mq2Manager.GetDataByDate(date);
            dataGridView1.DataSource = table;
            UpdateChart();
        }

        private void UpdateChart()
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            DataTable data = mq2Manager.GetChartData(selectedDate);

            var estadoCounts = data.AsEnumerable()
                .GroupBy(row => row.Field<string>("estado"))
                .Select(g => new
                {
                    Estado = g.Key,
                    Count = g.Count()
                })
                .ToList();

            int total = estadoCounts.Sum(e => e.Count);

            chart1.Series["EstadoData"].Points.Clear();

            foreach (var estado in estadoCounts)
            {
                double porcentaje = (double)estado.Count / total * 100;
                chart1.Series["EstadoData"].Points.AddXY(estado.Estado, porcentaje);
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadDataGridByDate(dateTimePicker1.Value.Date);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            mq2Manager.StartListening();
            LoadDataGrid();
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            mq2Manager.StopListening();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string estado = txtEstado.Text;
            string valor = txtGas.Text;
            mq2Manager.SaveData(estado, valor);
        }

        private void frmMQ2_Load(object sender, EventArgs e)
        {

        }
    }
}
