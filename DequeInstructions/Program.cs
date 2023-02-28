namespace DequeInstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deque= new MyDeque<int>(6);
            deque.Enqueue(1);
            deque.Push(15);
            Console.WriteLine(deque.Pop());
            Console.WriteLine(deque.Pop());
            Console.WriteLine(deque.Dequeue());
            Console.WriteLine(deque.Dequeue());

            Console.WriteLine(deque);
        }
    }
}