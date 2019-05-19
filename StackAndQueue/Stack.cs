using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Stack
    {
        public List<string> student;
        public int last;
        public Stack()
        {
            student = new List<string>();
            last = 0;
        }
        public void push(string name)
        {
            student.Add(name);
            last+=1;
        }
        public void pop()
        {
            last -= 1;
            student.RemoveAt(last);
        }
        public string peek()
        {
            return student[last-1];
        }
        public List<string> getData()
        {
            return student;
        }
    }
}
