///////////////////////////////////////////////////////////////////////////////
//
// Author: Travis Nagle, Naglet@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3 - Deque Instructions
// Description: Driver class that displays the features of a deque
//
///////////////////////////////////////////////////////////////////////////////

namespace DequeInstructions
{
    /// <summary>
    /// Driver class used to display the different methods used in a deque
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method to display deque functions
        /// </summary>
        /// <param name="args">string array parameters</param>
        static void Main(string[] args)
        {
            MyDeque<int> deque= new MyDeque<int>(6);
            deque.Enqueue(1);
            deque.Push(15);
            deque.Enqueue(12);
            deque.Push(13);
            deque.Push(14);
            deque.Enqueue(20);

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