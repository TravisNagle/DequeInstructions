namespace DequeInstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deque= new MyDeque<int>(4);
            deque.Push(15);
            Console.WriteLine(deque);
        }
    }
}