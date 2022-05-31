using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingTwoStack
{
    public class QueueUsingStack
    {
        Stack<int> s1;
        

        public QueueUsingStack()
        {
            s1 = new Stack<int>();
        }

        public void Push(int x)
        {
            if(s1.Count == 0)
            {
                s1.Push(x);
            }
            else
            {
                var s2 = new Stack<int>();
                while(s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
                s1.Push(x);

                while(s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                }
            }
        }

        public int Pop()
        {
            return s1.Pop();
        }

        public void Peek()
        {
            Console.WriteLine(s1.Peek()); 
        }

        public bool isEmpty()
        {
            return s1.Count == 0;
        }

        public void Display()
        {
            foreach(var item in s1)
            {
                Console.Write(item+ " ");
            }
        }
        
    }
}
