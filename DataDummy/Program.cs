using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDummy
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            List<int> listMahasiswa= mahasiswa.getAllNim();
        }
    }
}
