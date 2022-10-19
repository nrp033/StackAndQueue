using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class QueueLinkedList
    {
        //In Queue front and rear Nodes are present
        Node front;
        Node rear;


        //Enqueue method is Used to Add elements in the queue
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (front == null)
            {
                rear = newnode;
                front = rear;
            }
            else
            {
                rear.Next = newnode;
                rear = rear.Next;
            }
            Console.WriteLine("{0} Inserted into Queue", newnode.data);

        }
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Deletion of elements is not possible because Queue is Empty");
                return;
            }
            Console.WriteLine("\nElement Deleted from queue : {0} ", this.front.data);
            this.front = this.front.Next;
        }


        //Display method is used to display elements in queue

        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            Node temp = front;
            while (temp != null)
            {
                Console.Write(temp.data+" -> "  );
                temp = temp.Next;
            }
        }
    }
}
