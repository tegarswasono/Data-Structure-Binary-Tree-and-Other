using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDummy;

namespace LinearSearchAndBinarySearch2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataDummy.Mahasiswa m = new DataDummy.Mahasiswa();
            var data = m.getAllNim();


            //#01 Linear Search
            LinearSearch ls = new LinearSearch();
            var result1= ls.search(data, 7);


            //#02 Linear Search Recursion
            var result2 = ls.searchRecurtion(data, data.Count()-1, 7);


            //#03 Binary Search
            BinarySearch bs = new BinarySearch();
            var result3= bs.Search(data, 7);


            //#04 Binary Search Recursion
            var result4 = bs.SearchRecursif(data, 0, data.Count(), 7);
        }
    }
}
