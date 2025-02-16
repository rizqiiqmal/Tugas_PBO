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

namespace Management_Employees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == " " && Password.Text == " ")
            {
                MessageBox.Show(" Username dan Password tidak boleh kosong");
            }
               
            else if (richTextBox1.Text == "admin" && Password.Text == "123456")
            {
                ParentForm parentForm = new ParentForm();
                parentForm.Show();
                this.Hide();
            }
                
            else
            {
                MessageBox.Show("Harap masukan username dan password anda");
            }
        }
        
    }
}
