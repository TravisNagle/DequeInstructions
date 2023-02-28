namespace DequeInstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deque= new MyDeque<int>(6);
            deque.Enqueue(1);
            deque.Enqueue(2);
            deque.Enqueue(3);
            deque.Enqueue(4);
            deque.Enqueue(5);

            Console.WriteLine(deque.Dequeue());
            Console.WriteLine(deque.Dequeue());
            Console.WriteLine(deque.Dequeue());

            Console.WriteLine(deque.Dequeue());


            Console.WriteLine(deque);
        }
    }
}