///////////////////////////////////////////////////////////////////////////////
//
// Author: Travis Nagle, Naglet@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3 - DequeInstructions
// Description: Attempted implementation of the Deque data structure
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DequeInstructions
{
    public class MyDeque<T> : IStack<T>, IQueue<T>, ICollection
    {
        private T[] MyArray { get; set; }
        private int _count;
        private int _currentLocation;

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

        public int CurrentLocation
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                _currentLocation = Math.Min(MyArray.Length - 1, value);
            }
        }

        public bool IsSynchronized => false;

        public object SyncRoot => this;

        public T Dequeue() //Pulling from the start of the line
        {
            T initialResult = MyArray[0];
            if(Count == 0)
            {
                return default(T);
            }
            for(int i = Count - 1; i > 0; i--)
            {
                MyArray[i - 1] = MyArray[i];
            }
            Count--;
            return initialResult;
        }
        
        public void Enqueue(T item)
        {
            if(Count != MyArray.Length)
            {
                for(int i = 1; i < MyArray.Length; i++)
                {
                    MyArray[i] = MyArray[i - 1];
                }
                MyArray[0] = item;
                Count++;
            }
            else
            {
                throw new Exception("The Deque is full");
            }
        }

        public T Peek()
        {
            if (Count == 0)
            {
                return default(T);
            }
            return MyArray[Count - 1];
        }

        public T Pop()
        {
            if(Count == 0)
            {
                return default(T);
            }
            Count--;
            return MyArray[Count];
        }

        public void Push(T item)
        {
            MyArray[Count] = item;
            Count++;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string info = "";
            for(int i  = 0; i < MyArray.Length; i++)
            {
                info += $"{MyArray[i]}\n";
            }
            return info;
        }
    }
}
