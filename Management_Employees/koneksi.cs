using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Management_Employees
{
    public class Koneksi
    {
        private static readonly string connString = "Server=localhost;Database=management_employees;Uid=root;Pwd=;";

        // Method untuk mendapatkan koneksi baru setiap kali dibutuhkan
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }

        // Method untuk membuka koneksi
        public static void OpenConnection(MySqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // Method untuk menutup koneksi
        public static void CloseConnection(MySqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}