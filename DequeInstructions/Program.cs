namespace DequeInstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deque= new MyDeque<int>(6);
            deque.Push(1);
            deque.Push(2);
            deque.Push(3);
            deque.Push(4);
            deque.Push(5);
            Console.WriteLine(deque);
            deque.Enqueue(7);
            deque.Push(81);
            Console.WriteLine(deque);
            Console.WriteLine();

            Console.WriteLine(deque.Pop());
            Console.WriteLine(deque.Dequeue());
            Console.WriteLine(deque.Pop());
            Console.WriteLine(deque.Dequeue());
        }
    }
}