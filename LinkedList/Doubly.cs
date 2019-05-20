using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class Link
    {
        public int data;
        public Link next;
        public Link prev;
        public Link(int data)
        {
            this.data = data;
        }
    }
    public class Doubly
    {
        private Link first;
        private Link last;
        public Doubly()
        {
            first = null;
            last = null;
        }
        public void insertFirst(int data)
        {
            Link newdata = new Link(data);
            if (last==null)
            {
                last = newdata;
            }else
            {
                first.prev = newdata;
            }
            newdata.next = first;
            first = newdata;
        }
        public void deleteFirst()
        {
            Link temp = first;
            if (first.next==null)
            {
                last = null;
            }else
            {
                first.next.prev = null;
            }
            first = first.next;
        }
        public void deleteLast()
        {
            Link temp = last;
            if (first.next==null)
            {
                first = null;
            }else
            {
                last.prev.next = null;
            }
            last = last.prev;
        }

        public bool insertAfter(int key, int Data)
        {
            Link current = first;
            while (current.data != key)
            {
                current = current.next;
                if (current == null)
                {
                    return false;
                }
            }
            Link newLink = new Link(Data);
            if (current == last)
            {
                newLink.next = null;
                last = newLink;
            }
            else
            {
                newLink.next = current.next;
                current.next.prev = newLink;
            }
            newLink.prev = current;
            current.next = newLink;
            return true;
        }

        public bool deleteKey(int key)
        {
            Link current = first;
            while (current.data != key)
            {
                current = current.next;
                if (current == null)
                {
                    return false;
                }
            }
            if (current == first)
            {
                first = current.next;
            }
            else
            {
                current.prev.next =
                current.next;
            }
            if (current == last)
            {
                last = current.prev;
            }
            else
            {
                current.next.prev =
                current.prev;
            }
            return true;
        }
    }
}
