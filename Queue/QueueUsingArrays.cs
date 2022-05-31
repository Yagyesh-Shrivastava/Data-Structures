using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueUsingArrays
    {
        int[] arr;
        int capacity;
        int rear;
        int count = 0;

        public QueueUsingArrays(int capacity)
        {
            this.capacity = capacity;
            arr = new int[capacity];
            rear = -1;
        }

        //Enqueue
        public void Enqueue(int data)
        {
            if(rear == capacity-1)
            {
                throw new Exception("Queue is full!!!");
            }
            rear++;
            arr[rear] = data;
            count++;
        }

        //Dequeue
        public int Dequeue()
        {
            if(rear == -1)
            {
                throw new Exception("No element is present.. Can't delete!!!");
            }
            int result = arr[0];
            for(int i=0; i<rear; i++)
            {
                arr[i] = arr[i + 1];
            }
            rear--;
            count--;
            return result;
            
        }

        //Peek
        public void getFront()
        {
            if(rear==-1)
            {
                throw new Exception("No elements is present!!!");
            }
            Console.WriteLine(arr[0]);
        }

        //Display
        public void Display()
        {
            for(int i=0; i<count; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
