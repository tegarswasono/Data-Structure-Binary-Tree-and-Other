using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int id;
        public String data;
        public Node leftChild;
        public Node rightChild;
        public void displayNode()
        {
            Console.WriteLine("{ " + id + ", " + data + " } ");
        }
    }
}
