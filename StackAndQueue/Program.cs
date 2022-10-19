namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackLinkedList stack = new StackLinkedList();
            Console.WriteLine("Pushing Elements in the Stack as :\n");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("\nElement in stack given as :\n");
            stack.Display();
            Console.ReadKey();
        }
    }
}