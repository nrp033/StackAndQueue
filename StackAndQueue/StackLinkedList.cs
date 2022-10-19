using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class StackLinkedList
    {
        Node top;


        public StackLinkedList()
        {
            top = null;
        }
        public void Push(int data)//Method to add elements in stack
        {
            Node nodeObj = new Node(data);
            nodeObj.Next = top;
            top = nodeObj;
            Console.WriteLine("{0} Push to the stack", data);
        }
        public void Display()
        {
            if (top == null)
                Console.WriteLine("Stack is Empty here");

            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
    }
}
