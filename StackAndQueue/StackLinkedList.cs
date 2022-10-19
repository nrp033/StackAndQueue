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
            Console.Write( data+ "  ");
        }
        public void Display()
        {
            if (top == null)
                Console.WriteLine("\nStack is Empty ");

            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + "  ");
                temp = temp.Next;
            }
        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("\n{0} element is at the top of stack", this.top.data);
        }

        //pop method is used to delete element from the stack

        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }

            Console.Write("\n{0} Deleted from stack ", this.top.data);

            this.top = this.top.Next;

        }

        //IsEmpty method is used to empty the stack

        public void IsEmpty()
        {
            //just call peek and pop method to empty stack

            while (this.top != null)
            {
                Peek();
                pop();
            }
        }
    }
}
