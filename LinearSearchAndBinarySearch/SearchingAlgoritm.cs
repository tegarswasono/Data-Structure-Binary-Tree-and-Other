using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchAndBinarySearch
{
    public class SearchingAlgoritm
    {
        List<customer> lc;
        public SearchingAlgoritm()
        {
            lc = new List<customer>();
        }
        customer add(int nik, string name, string order)
        {
            customer ctm = new customer();
            ctm.nik = nik;
            ctm.name = name;
            ctm.order = order;
            return ctm;
        }
        void addData()
        {
            lc.Add(add(11, "ana", "sate"));
            lc.Add(add(15, "ani", "rawon"));
            lc.Add(add(19, "anu", "rendang"));
            lc.Add(add(22, "ano", "rendang"));
            lc.Add(add(25, "tona", "rendang"));

            lc.Add(add(27, "toni", "rendang"));
            lc.Add(add(32, "tonu", "rendang"));
            lc.Add(add(37, "tono", "rendang"));
            lc.Add(add(41, "joko", "rendang"));
            lc.Add(add(44, "joki", "rendang"));

            lc.Add(add(59, "joku", "rendang"));
            lc.Add(add(68, "joka", "rendang"));
        }
        public void PrintData()
        {
            addData();
            foreach (var a in lc)
            {
                Console.Write(a.nik);
                Console.Write(a.name);
                Console.WriteLine(a.order);
            }
            Console.ReadLine();
        }
        public customer linearSearch(int nik)
        {
            addData();
            foreach (var a in lc)
            {
                if (a.nik == nik)
                {
                    return a;
                }
            }
            customer result = new customer();
            return result;
        }
        public customer BinarySearch(int nik)
        {
            addData();
            int min = 0;
            int max = lc.Count - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (nik == lc[mid].nik)
                {
                    return lc[mid];
                }
                else if (nik < lc[mid].nik)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            customer result = new customer();
            return result;
        }
    }
}
