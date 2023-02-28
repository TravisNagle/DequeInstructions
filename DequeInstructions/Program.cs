namespace DequeInstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deque= new MyDeque<int>(6);
            deque.Enqueue(1);
            deque.Push(15);
            deque.Enqueue(12);
            deque.Push(13);

            Console.WriteLine("----Internal Array----");
            Console.WriteLine(deque);
            Console.WriteLine();

            Console.WriteLine("----Peek----");
            Console.WriteLine(deque.Peek());
            Console.WriteLine("----Pop----");
            Console.WriteLine(deque.Pop());
            Console.WriteLine(deque.Pop());
            Console.WriteLine("----Dequeue----");
            Console.WriteLine(deque.Dequeue());
            Console.WriteLine(deque.Dequeue());
        }
    }
}