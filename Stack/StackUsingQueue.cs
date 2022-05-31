using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingTwoQueue
{
    public class StackUsingQueue
    {
        Queue<int> queue1;
        Queue<int> queue2;

        public StackUsingQueue()
        {
            queue1 = new Queue<int>();
            queue2 = new Queue<int>();
        }

        public void Push(int x)
        {
            while(queue1.Count != 0)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            queue1.Enqueue(x);
            while(queue2.Count != 0)
            {
                   queue1.Enqueue(queue2.Dequeue());
            }
        }

        public int Pop()
        {
            return queue1.Dequeue();
        }
    }
}
