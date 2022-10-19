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
                    "2) Insert and Peek , Pop Elements from Stack Until Stack Become Empty");
                StackLinkedList stack = new StackLinkedList();
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



                    default:
                        check = false;
                        break;
                }
            }
        }
    }
}