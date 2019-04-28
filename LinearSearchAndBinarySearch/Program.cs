using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchAndBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchingAlgoritm sa = new SearchingAlgoritm();
            var result= sa.linearSearch(111);
            var resultBinarySearch= sa.BinarySearch(59);
        }
    }
}
