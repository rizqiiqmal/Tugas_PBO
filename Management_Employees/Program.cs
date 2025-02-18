using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Employees
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (loading loadingForm = new loading())
            {
                loadingForm.ShowDialog(); // Menampilkan loading sebelum Form1
            }

            // **Setelah Loading Selesai, Jalankan Form1 (Login)**
            Application.Run(new Form1());
        }
    }
}
