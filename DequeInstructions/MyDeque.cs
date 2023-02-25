using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DequeInstructions
{
    public class MyDeque<T> : IStack<T>, IQueue<T>
    {
        private T[] MyArray { get; set; }
        private int Count { get; set; }

        public MyDeque(int maxSize = 10)
        {
            MyArray= new T[maxSize];
        }

        public T Dequeue()
        {

            throw new NotImplementedException();
        }

        public void Enqueue(T item)
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T item)
        {
            MyArray[Count] = item;
            Count++;
        }

        public override string ToString()
        {
            string info = "";
            foreach(var item in MyArray)
            {
                info += $"{item}\n";
            }
            return info;
        }
    }
}
