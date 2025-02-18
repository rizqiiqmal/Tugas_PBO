using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Employees
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Keluar dari seluruh aplikasi
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            Employee EmployeeForm = new Employee();
            EmployeeForm.Show();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
