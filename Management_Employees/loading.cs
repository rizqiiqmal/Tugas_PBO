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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            this.Shown += new EventHandler(Loading_Shown);
        }

        private async void Loading_Shown(object sender, EventArgs e)
        {
            this.Show(); // **Pastikan form muncul sebelum delay**
            await Task.Delay(3000); // **Tunggu 3 detik**
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
