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
        private int _count;

        public MyDeque(int maxSize = 10)
        {
            MyArray= new T[maxSize];
        }

        public int Count
        {
            get 
            { 
                return _count; 
            }
            set 
            { 
                _count = Math.Max(0, value); 
            }
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
            Count--;
            return MyArray[Count];
        }

        public void Push(T item)
        {
            MyArray[Count] = item;
            Count++;
        }
    }
}
