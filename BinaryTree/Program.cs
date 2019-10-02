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

            while (true)
            {
                Console.Write("Enter first letter of show, "+ "insert, find, delete, or traverse: ");
                int choice = getChar();
                switch (choice)
                {
                    case 's':
                        theTree.displayTree();
                        break;
                    case 'i':
                        Console.Write("Enter value and data to"+ " insert: ");
                        value = getInt();
                        data = getString();
                        theTree.insert(value, data);
                        break;
                    case 'f':
                        Console.Write("Enter value to find: ");
                        value = getInt();
                        Node found = theTree.find(value);
                        if (found != null)
                        {
                            Console.Write("Found: ");
                            found.displayNode();
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.Write("Could not find "+ value);
                        }
                        break;
                    case 'd':
                        Console.Write("Enter value to delete: ");
                        value = getInt();
                        bool didDelete = theTree.delete(value);
                        if (didDelete)
                        {
                            Console.Write("Deleted " + value);
                        }
                        else
                        {
                            Console.Write("Could not delete "+ value);
                        }
                        break;
                    case 't':
                        Console.Write("Enter type 1, 2 or 3: ");
                        value = getInt();
                        theTree.traverse(value);
                        break;
                    default:
                        Console.Write("Invalid entry ");
                        break;
                }
            }
        }
        public static char getChar()
        {
            String s = getString();
            var tmp = s.ToCharArray();
            char result = 'z';
            if (tmp.Count()>0)
            {
                result = tmp[0];
            }
            return result;
        }
        public static String getString()
        {
            string s = Console.ReadLine();
            return s;
        }
        public static int getInt()
        {
            String s = getString();
            return int.Parse(s);
        }
    }
}
