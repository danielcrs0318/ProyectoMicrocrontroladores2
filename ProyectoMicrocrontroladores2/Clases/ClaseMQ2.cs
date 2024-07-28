using System;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ProyectoMicrocrontroladores2.Clases;

namespace ProyectoMicrocrontroladores2.Clases
{
    public class ClaseMQ2
    {
        private SerialPort Port;
        private bool IsClosed;
        private ClaseConexion dbManager;
        private Thread Hilo;

        public ClaseMQ2()
        {
            Port = new SerialPort
            {
                PortName = "COM3",
                BaudRate = 9600,
                ReadTimeout = 500
            };

            dbManager = new ClaseConexion();
            IsClosed = false;
        }

        public void StartListening()
        {
            try
            {
                Port.Open();
                Console.WriteLine("Conexión al puerto serie establecida.");
                IsClosed = false;
                Hilo = new Thread(EscucharSerial)
                {
                    IsBackground = true
                };
                Hilo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el puerto: {ex.Message}");
            }
        }

        public void StopListening()
        {
            IsClosed = true;
            if (Port.IsOpen)
            {
                Port.Close();
                Console.WriteLine("Puerto serie cerrado.");
            }
        }

        private void EscucharSerial()
        {
            while (!IsClosed)
            {
                try
                {
                    if (Port.IsOpen)
                    {
                        string cadena = Port.ReadLine();
                        Console.WriteLine($"Datos recibidos: {cadena}");
                        string[] partes = cadena.Split(',');

                        if (partes.Length == 2)
                        {
                            string estado = partes[0];
                            string valor = partes[1];

                            // Call to some event or delegate to update UI
                        }
                        else
                        {
                            Console.WriteLine("Datos recibidos en formato incorrecto.");
                        }
                    }
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("Timeout al leer del puerto.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer del puerto: {ex.Message}");
                }
            }
        }

        public void SaveData(string estado, string valor)
        {
            if (!string.IsNullOrEmpty(estado) && !string.IsNullOrEmpty(valor))
            {
                string query = $"INSERT INTO DatosMQ2 (estado, valor, Fecha) VALUES ('{estado}', '{valor}', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')";
                if (dbManager.Ejecutar(query))
                {
                    MessageBox.Show("Datos guardados en la base de datos.");
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para guardar.");
            }
        }

        public DataTable GetDataByDate(DateTime date)
        {
            string query = $"SELECT * FROM DatosMQ2 WHERE Fecha = '{date:yyyy-MM-dd}'";
            return dbManager.Query(query);
        }

        public DataTable GetAllData()
        {
            return dbManager.Query("SELECT * FROM DatosMQ2");
        }

        public DataTable GetChartData(DateTime date)
        {
            string query = $"SELECT estado, COUNT(*) AS Count FROM DatosMQ2 WHERE Fecha = '{date:yyyy-MM-dd}' GROUP BY estado";
            return dbManager.Query(query);
        }
    }
}
