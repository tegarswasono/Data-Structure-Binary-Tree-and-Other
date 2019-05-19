using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Queue
    {
        private List<string> student;
        private int last;
        public Queue()
        {
            student = new List<string>();
            last = 0;
        }
        public void push(string name)
        {
            student.Add(name);
            last += 1;
        }
        public void pop()
        {
            student.RemoveAt(0);
            last -= 1;
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
