using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            String data;
            Tree theTree = new Tree();
            theTree.insert(50, "Ahmad");
            theTree.insert(25, "Rosa");
            theTree.insert(75, "Raisa");
            theTree.insert(12, "Naya");
            theTree.insert(37, "Gagas");
            theTree.insert(43, "Ainun");
            theTree.insert(30, "Beri");
            theTree.insert(33, "Vivid");
            theTree.insert(87, "Orin");
            theTree.insert(93, "Wiwid");
            theTree.insert(97, "Sasa");
        }
    }
}
