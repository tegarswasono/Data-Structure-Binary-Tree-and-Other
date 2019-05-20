using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Singly s = new Singly();
            s.insertFirst(3);
            s.insertFirst(5);
            s.insertFirst(7);
            s.insertFirst(9);
            s.insertFirst(11);
            s.insertFirst(13);
            s.deleteFirst();

            var result = s.find(7);
            var result2 = s.delete(5);
        }
    }
}
