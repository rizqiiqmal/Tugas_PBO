using System;
using System.Data;
using MySql.Data.MySqlClient;
using Management_Employees.Model;

namespace Management_Employees.Controller
{
    internal class C_jabatan
    {
        public DataTable GetJabatan()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "SELECT * FROM jabatan";
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
                    Koneksi.CloseConnection(conn);
                }
            }
            return dt;
        }

        public void AddJabatan(M_jabatan jabatan)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "INSERT INTO jabatan (nama_jabatan) VALUES (@nama)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", jabatan.Nama);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    Koneksi.CloseConnection(conn);
                }
            }
        }

        public void UpdateJabatan(M_jabatan jabatan)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "UPDATE jabatan SET nama_jabatan = @nama WHERE id_jabatan = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", jabatan.Id);
                        cmd.Parameters.AddWithValue("@nama", jabatan.Nama);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    Koneksi.CloseConnection(conn);
                }
            }
        }

        public void DeleteJabatan(int id)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "DELETE FROM jabatan WHERE id_jabatan = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    Koneksi.CloseConnection(conn);
                }
            }
        }
    }
}
