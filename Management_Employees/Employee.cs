using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Employees
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            DisplayKaryawan();
        }

        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\karyawan.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayKaryawan()
        {
            try
            {
                Con.Open();
                string Query = "select * from TabelKaryawan";
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }



        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            ParentForm parentForm = new ParentForm();
            parentForm.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " ") 
                {
                    MessageBox.Show("Data Kosong");
                }
                else
                {
                    Con.Open();
                    string query = "Insert into TabelKaryawan value ('"+ textBox1.Text +"', '"+ textBox3.Text +"', '"+ comboBox1.SelectedItem.ToString() +"', '"+ textBox4.Text +"', '" + comboBox2.SelectedItem.ToString() +"', '"+ textBox5.Text +"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Berhasil Menambahkan Data");
                    DisplayKaryawan();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                Con.Close();
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
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("masukan id karyawan");
                }
                else
                {
                    Con.Open();
                    string query = "delete from TabelKaryawan WHERE id_karyawan= '" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand (query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Data Berhasil Dihapus");
                    DisplayKaryawan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                Con.Close();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";
            textBox4.Text = " ";
            comboBox2.Text = " ";
            textBox5.Text = " ";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
                {
                    MessageBox.Show("Data Kosong");
                }
                else
                {
                    Con.Open();
                    string query = "Update TabelKaryawan set id_karyawan='" + textBox1.Text + "', nama_karyawan='" + textBox3.Text + "', jenisKelamin_karyawan='" + comboBox1.SelectedItem.ToString() + "', alamat_karyawan='" + textBox4.Text + "', jabatan_karyawan='" + comboBox2.SelectedItem.ToString() + "', noHp_karyawan='" + textBox5.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Berhasil Mengubah Data");
                    DisplayKaryawan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


        }
    }
}
