namespace DequeInstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deque= new MyDeque<int>();
            deque.Push(15);
            deque.Push(15);
            deque.Enqueue(12);
            deque.Push(15);
            deque.Push(15);
            deque.Enqueue(12);
            deque.Enqueue(12);
            deque.Push(15);
            deque.Push(15);
            //deque.Dequeue();
            Console.WriteLine(deque);

        }
    }
}