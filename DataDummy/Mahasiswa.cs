using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDummy
{
    public class Mahasiswa
    {
        List<int> nim;
        public Mahasiswa()
        {
            nim = new List<int>();
        }
        public List<int> getAllNim()
        {
            nim.Add(3);
            nim.Add(7);
            nim.Add(9);
            nim.Add(11);
            nim.Add(13);
            nim.Add(18);
            nim.Add(29);
            nim.Add(34);
            nim.Add(55);
            return nim;
        }
    }
}
