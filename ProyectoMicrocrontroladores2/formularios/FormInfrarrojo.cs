using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoMicrocrontroladores2.formularios
{
    public partial class FormInfrarrojo : Form
    {
        SerialPort puerto;
        private Clasesensores s1;
        private SqlConnection con;
        private SqlDataAdapter ad;
        private DataTable data;
        private Boolean cf = true;


        public FormInfrarrojo()
        {
            InitializeComponent();
            string connectionString = "Data Source=localhost;Initial Catalog=proyectoMicrocontroladores;Integrated Security=True;Max Pool Size=100;";
            con = new SqlConnection(connectionString);
            s1 = new Clasesensores();
            //tabladatos();
            puerto = new SerialPort
            {
                DtrEnable = true,
                BaudRate = 9600,
                PortName = "COM3"
            };
            puerto.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {

                puerto.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("Conectar el arduino");
            }


        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (puerto.IsOpen)
                {
                    //tabladatos();
                    string data = puerto.ReadLine().Trim();

                    string[] partes = data.Split(',');

                    if (partes.Length == 3)
                    {
                        int valorInfrarrojo = int.Parse(partes[1]);
                        String colorDetectado = partes[0];
                        int gradosServo = int.Parse(partes[2]);


                        this.Invoke(new Action(() =>
                        {
                            DATOSCOLOR.Text = colorDetectado;
                            DATOSINFRA.Text = valorInfrarrojo.ToString();
                            DATOSSERVO.Text = gradosServo.ToString();



                            //s1 = new clasesensores();
                            //s1.INICIAR();


                        }));
                        s1 = new Clasesensores(valorInfrarrojo, colorDetectado, gradosServo);
                        s1.INICIAR();

                    }

                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => MessageBox.Show("Error al leer el valor del puerto serie: {ex.Message}")));
            }
        }

        private void BTNINICIAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (!puerto.IsOpen)
                {
                    puerto.Open();
                }
                puerto.Write("A");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar datos a Arduino: " + ex.Message);
            }

        }

        private void BTNAPAGAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (!puerto.IsOpen)
                {
                    puerto.Open();
                }
                puerto.Write("B");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar datos a Arduino: " + ex.Message);
            }
        }

        private void FormInfrarrojo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (puerto.IsOpen)
            {
                puerto.Close();
            }
        }


        private DataTable Analisis(DateTime fechaSeleccionada)
        {

            string connectionString = "Data Source=localhost;Initial Catalog=proyectoMicrocontroladores;Integrated Security=True;Max Pool Size=100;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAnalisis_FechaaAa", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@A_Fecha", fechaSeleccionada);


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                  DataTable TABLA = new DataTable();
                    



                    return dt;
                }
            }

        }

        private void BTNCONSULTAR_Click(object sender, EventArgs e)
        {
            
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DataTable dt = Analisis(fechaSeleccionada);
            dataGridView1.DataSource = dt;

            double totalValorInfrarrojo = 0;
            int countAperturas = 0;
            double energiaPorApertura = 0.000000083;

            foreach (DataRow row in dt.Rows)
            {
                if (double.TryParse(row["ValorInfrarrojo"].ToString(), out double valorInfrarrojo))
                {
                    totalValorInfrarrojo += valorInfrarrojo;
                }

                if (double.TryParse(row["GradosServomotor"].ToString(), out double gradosServomotor))
                {
                    if (gradosServomotor == 180)
                    {
                        countAperturas++;
                    }
                }
            }
            double energiaTotal = countAperturas * energiaPorApertura;
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
                 
            var point1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
            point1.AxisLabel = "Total Valor Infrarrojo";
            point1.YValues = new double[] { totalValorInfrarrojo };
            point1.Color = Color.Blue;

            var point2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
            point2.AxisLabel = "Cantidad de Energía";
            point2.YValues = new double[] { energiaTotal };
            point2.Color = Color.Red;

            series.Points.Add(point1);
            series.Points.Add(point2);
 
            chart1.Legends.Clear();
            var legend = chart1.Legends.Add("Leyenda1");
            legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend.Alignment = System.Drawing.StringAlignment.Center;

            series.Legend = legend.Name;

            foreach (var point in series.Points)
            {
                point.Label = string.Format("{0}: {1:N10}", point.AxisLabel, point.YValues[0]);
            }
        }

        


        private void tabladatos()
        {

            string connectionString = "server=localhost;database=tienda;uid=Mamado2;pwd=123;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ValoresSensores", con); // Prepara preparrar el comando mysql

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // adaptador de datos para hahcere la consdula

                    DataTable dt = new DataTable();//datatable con los datos para infgrear a la db
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;// el datagriewviwe1 para los datos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

        }

        private void recargartabla()
        {


        }

        private void buscar(DataGridView d)
        {


            SqlCommand cmd = new SqlCommand("SELECT * FROM ValoresSensores where FechaHora = spAnalisis_FechaaAbrietoa ", con);


        }
    }
}
