using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Management_Employees
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            DisplayKaryawan();
        }

        private void DisplayKaryawan()
        {
            try
            {
                using (MySqlConnection koneksi = Koneksi.GetConnection())
                {
                    koneksi.Open();
                    string query = "SELECT * FROM tabelkaryawan";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, koneksi);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection koneksi = Koneksi.GetConnection())
                {
                    koneksi.Open();
                    string query = "INSERT INTO tabelkaryawan (nama_karyawan, jenisKelamin_karyawan, alamat_karyawan, jabatan_karyawan, noHp_karyawan) " +
                           "VALUES (@nama, @jk, @alamat, @jabatan, @noHp)";
                    MySqlCommand cmd = new MySqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@nama", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@jk", comboBox1.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@alamat", textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@jabatan", comboBox2.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@noHp", textBox5.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Ditambahkan!");
                    DisplayKaryawan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DisplayKaryawan();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Pilih data karyawan yang ingin dihapus!");
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection koneksi = Koneksi.GetConnection())
                    {
                        koneksi.Open();
                        string query = "DELETE FROM tabelkaryawan WHERE id_karyawan = @id";
                        MySqlCommand cmd = new MySqlCommand(query, koneksi);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus!");
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan atau gagal dihapus.");
                        }

                        DisplayKaryawan(); // Refresh DataGridView setelah hapus data
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox4.Clear();
            comboBox2.SelectedIndex = -1;
            textBox5.Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Pilih data karyawan yang ingin diperbarui!");
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengupdate data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection koneksi = Koneksi.GetConnection())
                    {
                        koneksi.Open();
                        string query = "UPDATE tabelkaryawan SET nama_karyawan = @nama, jenisKelamin_karyawan = @jk, alamat_karyawan = @alamat, " +
                              "jabatan_karyawan = @jabatan, noHp_karyawan = @noHp WHERE id_karyawan = @id";
                        MySqlCommand cmd = new MySqlCommand(query, koneksi);
                        int id_karyawan;
                        if (!int.TryParse(textBox1.Text, out id_karyawan))
                        {
                            MessageBox.Show("ID Karyawan tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        cmd.Parameters.AddWithValue("@id", id_karyawan);
                        cmd.Parameters.AddWithValue("@nama", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@jk", comboBox1.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@alamat", textBox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@jabatan", comboBox2.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@noHp", textBox5.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diperbarui!");
                        }
                        else
                        {
                            MessageBox.Show("Data gagal diperbarui atau tidak ditemukan.");
                        }

                        DisplayKaryawan(); // Refresh DataGridView setelah update data
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value?.ToString() ?? "";
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value?.ToString() ?? "";
            }

        }
    }
}
