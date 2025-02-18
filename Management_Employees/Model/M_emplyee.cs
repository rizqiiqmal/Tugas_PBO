using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Employees.Model
{
    internal class M_emplyee
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string Alamat { get; set; }
        public string Jabatan { get; set; }
        public string NoHp { get; set; }
        public int IdJabatan { get; set; }
    }
}
