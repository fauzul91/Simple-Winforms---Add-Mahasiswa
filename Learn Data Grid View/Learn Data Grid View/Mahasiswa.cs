using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Data_Grid_View
{
    public class Mahasiswa
    {
        public string nama {  get; set; }
        public string nim { get; set; }
        public int semester{ get; set; }
        public string email { get; set; }

        public Mahasiswa(string nama, string nim, int semester, string email)
        {
            this.nama = nama;
            this.nim = nim;
            this.semester = semester;
            this.email = email;
        }
    }
}
