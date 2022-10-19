namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("\n\n****Choose From the Following Options****\n\n");
                Console.WriteLine("\n1) Insert And Diplay Element Into Stack\n" +
                   "2) Insert and Peek , Pop Elements from Stack Until Stack Become Empty\n" +
                   "3) Insert and Display Element in Queue Using enqueue\n" +
                   "4) Deleting First Element in Queue using Dequeue\n");
                StackLinkedList stack = new StackLinkedList();
                QueueLinkedList queue = new QueueLinkedList();
                Console.Write("\n\nEnter Your Choice : ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        Console.WriteLine("Pushing Elements in the Stack as :\n");
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        Console.WriteLine("\nElement in stack given as :\n");
                        stack.Display();
                        break;

                    case 2:

                        Console.WriteLine("Pushing Elements in the Stack as :\n");
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        Console.WriteLine("\n\nElement in stack Stored as :\n");
                        stack.Display();
                        stack.IsEmpty();
                        stack.Display();
                        break;


                    case 3:

                        Console.WriteLine("Adding elements in the Queue :");
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        Console.WriteLine("\nQueue Contains :  \n");
                        queue.Display();
                        break;
                    case 4:
                        Console.WriteLine("Adding elements in the Queue :");

                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        queue.Display();
                        queue.Dequeue();
                        queue.Display();

                        break;




                    default:
                        check = false;
                        break;
                }
            }
        }
    }
}