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
using Management_Employees.Model;
using MySql.Data.MySqlClient;

namespace Management_Employees
{
    public partial class Employee : Form
    {
        private EmployeeController _controller;

        public Employee()
        {
            InitializeComponent();
            _controller = new EmployeeController();
            DisplayKaryawan();
            LoadJabatan();
        }

        private void DisplayKaryawan()
        {
            try
            {
                dataGridView1.DataSource = _controller.GetEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadJabatan()
        {
            try
            {
                DataTable dtJabatan = _controller.GetJabatan();
                comboBox2.DataSource = dtJabatan;
                comboBox2.DisplayMember = "nama_jabatan";
                comboBox2.ValueMember = "id_jabatan";
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
                var employee = new M_emplyee
                {
                    Nama = textBox3.Text.Trim(),
                    JenisKelamin = comboBox1.SelectedItem?.ToString() ?? "",
                    Alamat = textBox4.Text.Trim(),
                    Jabatan = comboBox2.SelectedItem?.ToString() ?? "",
                    NoHp = textBox5.Text.Trim(),
                    IdJabatan = Convert.ToInt32(comboBox2.SelectedValue)
                };
                _controller.AddEmployee(employee);
                MessageBox.Show("Data Berhasil Ditambahkan!");
                DisplayKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            DisplayKaryawan();
            LoadJabatan();
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
                    _controller.DeleteEmployee(Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Data berhasil dihapus!");
                    DisplayKaryawan();
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
                    var employee = new M_emplyee
                    {
                        Id = Convert.ToInt32(textBox1.Text),
                        Nama = textBox3.Text.Trim(),
                        JenisKelamin = comboBox1.SelectedItem?.ToString() ?? "",
                        Alamat = textBox4.Text.Trim(),
                        Jabatan = comboBox2.SelectedItem?.ToString() ?? "",
                        NoHp = textBox5.Text.Trim(),
                        IdJabatan = Convert.ToInt32(comboBox2.SelectedValue)
                    };
                    _controller.UpdateEmployee(employee);
                    MessageBox.Show("Data berhasil diperbarui!");
                    DisplayKaryawan();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
