using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackUsingArray
    {
        int[] arr;
        int top;
        int capacity;
        int count = 0;

        public StackUsingArray(int capacity)
        {
            this.capacity = capacity;
            top = -1;
            arr = new int[capacity];    
        }

        //Adding the data in stack
        public void push(int data)
        {
            if(top == capacity-1)
            {
                Console.WriteLine("Stack is full.. Not able to insert data");
            }
            top++;
            arr[top] = data;
            count ++;
        }

        //Removing the data from Stack
        public int pop()
        {
            if(isEmpty())
            {
                throw new Exception("Stack Uderflow!!!");
            }
            int result = arr[top];
            top = top -1;
            count --;
            return result;
        }

        //To see the top most element in Stack
        public void peek()
        {
            if(top == 1)
            {
                throw new Exception("Stack is Empty!!!");
            }
            Console.WriteLine(arr[top]);
        }

        //To check the stack is empty or not
        public bool isEmpty()
        {
            return top == -1;
        }

        //show elements of stack
        public void Display()
        {
            for(int i=0; i<count; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
