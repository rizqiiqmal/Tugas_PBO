using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Management_Employees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CobaKoneksiDatabase();
        }

        private void CobaKoneksiDatabase()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi database gagal: " + ex.Message);
            }
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = richTextBox1.Text.Trim();
            string password = Password.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ParentForm parentForm = new ParentForm();
                parentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            bool isValid = false;

            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    Koneksi.OpenConnection(conn);
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = MD5(@password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Koneksi.CloseConnection(conn);
                }
            }

            return isValid;
        }
    }
}
