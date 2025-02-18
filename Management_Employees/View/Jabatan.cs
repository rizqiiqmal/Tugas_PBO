using System;
using System.Data;
using System.Windows.Forms;
using Management_Employees.Controller;
using Management_Employees.Model;

namespace Management_Employees.View
{
    public partial class Jabatan : Form
    {
        private C_jabatan _controller;

        public Jabatan()
        {
            InitializeComponent();
            _controller = new C_jabatan();
            DisplayJabatan();

            // Tambahkan event handler untuk CellDoubleClick
            this.dataGridJabatan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJabatan_CellContentClick);
        }

        private void DisplayJabatan()
        {
            try
            {
                dataGridJabatan.DataSource = _controller.GetJabatan();
                // Optional: Atur nama kolom agar konsisten
                dataGridJabatan.Columns["id_jabatan"].HeaderText = "ID Jabatan";
                dataGridJabatan.Columns["nama_jabatan"].HeaderText = "Nama Jabatan";
                // Sembunyikan ID Jabatan jika tidak perlu ditampilkan
                dataGridJabatan.Columns["id_jabatan"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_jabatan_Click_1(object sender, EventArgs e)
        {
            try
            {
                var jabatan = new M_jabatan
                {
                    Nama = text_jabatan.Text.Trim()
                };
                _controller.AddJabatan(jabatan);
                MessageBox.Show("Data Jabatan Berhasil Ditambahkan!");
                DisplayJabatan();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_jabatan.Tag == null || string.IsNullOrEmpty(text_jabatan.Tag.ToString()))
                {
                    MessageBox.Show("Pilih data jabatan yang ingin diperbarui!");
                    return;
                }

                var jabatan = new M_jabatan
                {
                    Id = Convert.ToInt32(text_jabatan.Tag),
                    Nama = text_jabatan.Text.Trim()
                };
                _controller.UpdateJabatan(jabatan);
                MessageBox.Show("Data Jabatan Berhasil Diperbarui!");
                DisplayJabatan();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_jabatan.Tag == null || string.IsNullOrEmpty(text_jabatan.Tag.ToString()))
                {
                    MessageBox.Show("Pilih data jabatan yang ingin dihapus!");
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(text_jabatan.Tag);
                    _controller.DeleteJabatan(id);
                    MessageBox.Show("Data Jabatan Berhasil Dihapus!");
                    DisplayJabatan();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Add the missing method
        private void dataGridJabatan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridJabatan.Rows[e.RowIndex];
                if (row.Cells["nama_jabatan"].Value != null && row.Cells["id_jabatan"].Value != null)
                {
                    text_jabatan.Text = row.Cells["nama_jabatan"].Value.ToString();
                    text_jabatan.Tag = row.Cells["id_jabatan"].Value.ToString();
                }
            }
        }

        private void Jabatan_Load(object sender, EventArgs e)
        {
            DisplayJabatan();
        }

        private void ClearForm()
        {
            text_jabatan.Clear();
            text_jabatan.Tag = null;
        }
    }
}
