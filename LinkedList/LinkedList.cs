using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Node Next;
        public object Value;
    }


    public class LinkedList
    {
        private Node head;
        private Node Current;
        public int Count;


        public LinkedList()
        {
            head = new Node();
            Current = head;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            Current.Next = newNode;
            Current = newNode;
            Count++;
        }
    }
}
