using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is example of Stack and Queue Using List, FYI stack and queue can implement using array or linkedlist
            Stack s = new Stack();
            s.push("tono");
            s.push("toni");
            s.push("tonu");
            s.pop();
            s.pop();
            var peek = s.peek();
            var result= s.getData();


            Queue q = new Queue();
            q.push("tono");
            q.push("toni");
            q.push("tonu");
            q.pop();
            var peek2 = q.peek();
            var result2 = q.getData();
        }
    }
}
