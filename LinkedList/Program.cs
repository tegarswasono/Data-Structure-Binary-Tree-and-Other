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
            //SINGLE LINKED LIST
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



            //DOUBLE LINKED LIST
            LinkedList2.Doubly d = new LinkedList2.Doubly();
            d.insertFirst(1);
            d.insertFirst(3);
            d.insertFirst(5);
            d.insertFirst(7);
            d.insertFirst(9);
            d.insertFirst(11);
            d.insertFirst(13);
            d.insertFirst(15);
            d.deleteFirst();
            d.deleteLast();

            var result3 = d.deleteKey(7);
            var result4 = d.insertAfter(9, 33);

        }
    }
}
