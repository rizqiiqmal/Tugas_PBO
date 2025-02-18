using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_Employees.Model;
using MySql.Data.MySqlClient;

namespace Management_Employees
{
    internal class EmployeeController
        {
        public DataTable GetEmployees()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "SELECT * FROM tabelkaryawan";
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
        public void AddEmployee(M_emplyee employee)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "INSERT INTO tabelkaryawan (nama_karyawan, jenisKelamin_karyawan, alamat_karyawan, jabatan_karyawan, noHp_karyawan) " +
                                   "VALUES (@nama, @jk, @alamat, @jabatan, @noHp)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", employee.Nama);
                        cmd.Parameters.AddWithValue("@jk", employee.JenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", employee.Alamat);
                        cmd.Parameters.AddWithValue("@jabatan", employee.Jabatan);
                        cmd.Parameters.AddWithValue("@noHp", employee.NoHp);
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
        public void UpdateEmployee(M_emplyee employee)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "UPDATE tabelkaryawan SET nama_karyawan = @nama, jenisKelamin_karyawan = @jk, alamat_karyawan = @alamat, " +
                                   "jabatan_karyawan = @jabatan, noHp_karyawan = @noHp WHERE id_karyawan = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);
                        cmd.Parameters.AddWithValue("@nama", employee.Nama);
                        cmd.Parameters.AddWithValue("@jk", employee.JenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", employee.Alamat);
                        cmd.Parameters.AddWithValue("@jabatan", employee.Jabatan);
                        cmd.Parameters.AddWithValue("@noHp", employee.NoHp);
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
        public void DeleteEmployee(int id)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "DELETE FROM tabelkaryawan WHERE id_karyawan = @id";
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
