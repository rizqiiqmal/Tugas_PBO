using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Management_Employees
{
    internal class EmployeeController
        {
        public DataTable GetEmployees()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Koneksi.GetConnection()) // Buat koneksi baru
            {
                try
                {
                    Koneksi.OpenConnection(conn); // Buka koneksi dengan parameter
                    string query = "SELECT * FROM employees";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    Koneksi.CloseConnection(conn); // Tutup koneksi setelah selesai
                }
            }
            return dt;
        }
    }
}
