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
                    string query = "SELECT k.id_karyawan, k.nama_karyawan, k.jenisKelamin_karyawan, k.alamat_karyawan, j.nama_jabatan, k.noHp_karyawan " +
                                   "FROM tabelkaryawan k " +
                                   "LEFT JOIN jabatan j ON k.id_jabatan = j.id_jabatan";
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

        public DataTable GetJabatan()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "SELECT id_jabatan, nama_jabatan FROM jabatan";
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
                    string query = "INSERT INTO tabelkaryawan (nama_karyawan, jenisKelamin_karyawan, alamat_karyawan, jabatan_karyawan, noHp_karyawan, id_jabatan) " +
                                   "VALUES (@nama, @jk, @alamat, @jabatan, @noHp, @id_jabatan)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", employee.Nama);
                        cmd.Parameters.AddWithValue("@jk", employee.JenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", employee.Alamat);
                        cmd.Parameters.AddWithValue("@jabatan", employee.Jabatan);
                        cmd.Parameters.AddWithValue("@noHp", employee.NoHp);
                        cmd.Parameters.AddWithValue("@id_jabatan", employee.IdJabatan);
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
                                   "jabatan_karyawan = @jabatan, noHp_karyawan = @noHp, id_jabatan = @id_jabatan WHERE id_karyawan = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);
                        cmd.Parameters.AddWithValue("@nama", employee.Nama);
                        cmd.Parameters.AddWithValue("@jk", employee.JenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", employee.Alamat);
                        cmd.Parameters.AddWithValue("@jabatan", employee.Jabatan);
                        cmd.Parameters.AddWithValue("@noHp", employee.NoHp);
                        cmd.Parameters.AddWithValue("@id_jabatan", employee.IdJabatan);
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