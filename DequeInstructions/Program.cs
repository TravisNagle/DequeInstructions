namespace DequeInstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deque= new MyDeque<int>();
            deque.Push(15);
            deque.Push(15);
            deque.Push(15);
            deque.Push(15);
            deque.Push(15);
        }
    }
}