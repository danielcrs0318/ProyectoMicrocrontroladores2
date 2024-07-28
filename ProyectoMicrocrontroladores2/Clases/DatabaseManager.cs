using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoMicrocrontroladores2.Clases
{
    public class DatabaseManager
    {
        private string connectionString;
        public event Action DataUpdated;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SaveData(string estado, string valor)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO DatosMQ2 (estado, valor, fecha) VALUES (@estado, @valor, @fecha)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@valor", valor);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    Console.WriteLine("Datos guardados en la base de datos.");

                    // Invocar el evento DataUpdated si hay suscriptores
                    DataUpdated?.Invoke();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al guardar en la base de datos: {ex.Message}");
                }
            }
        }

        public DataTable LoadData()
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM DatosMQ2";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al cargar datos de la base de datos: {ex.Message}");
                }
            }
            return table;
        }

        public DataTable LoadDataByDate(DateTime date)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM DatosMQ2 WHERE fecha = @fecha";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fecha", date);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al cargar datos de la base de datos: {ex.Message}");
                }
            }
            return table;
        }
    }
}
