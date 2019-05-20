using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Link
    {
        public int data;
        public Link next;
        public Link(int data)
        {
            this.data = data;
        }
        public void displayLink()
        {
            Console.WriteLine(data+" ");
        }
    }
    class Singly
    {
        private Link first;
        public Singly()
        {
            first = null;
        }
        public void insertFirst(int data)
        {
            Link newlink = new Link(data);
            newlink.next = first;
            first = newlink;
        }
        public void deleteFirst()
        {
            first = first.next;
        }

        public bool find(int key)
        {
            Link current = first;
            while (current.data!=key)
            {
                if (current.next==null)
                {
                    return false;
                }else
                {
                    current = current.next;
                }
            }
            return true;
        }
        public bool delete(int key)
        {
            Link current = first;
            Link previous = first;
            while (current.data!=key)
            {
                if (current.next==null)
                {
                    return false;
                }else
                {
                    previous = current;
                    current = current.next;
                }
            }
            if (current==first)
            {
                first = first.next;
            }else
            {
                previous.next = current.next;
            }
            return true;
        }
    }
}
