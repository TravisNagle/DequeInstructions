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
    public class MyDeque<T> : IStack<T>, IQueue<T>
    {
        private T[] MyArray { get; set; }
        private int _count;
        private int currentLocation;
        private int queueCount = 0;

        public MyDeque(int maxSize = 10)
        {
            MyArray= new T[maxSize];
            currentLocation = 0;
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
            T result = MyArray[currentLocation];
            currentLocation++;
            if(currentLocation == MyArray.Length)
            {
                currentLocation = 0;
            }
            return result;
        }
        
        public void Enqueue(T item)
        {
            MyArray[queueCount] = item;
            queueCount++;
            if(queueCount == MyArray.Length && currentLocation != 0)
            {
                queueCount = 0;
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

        public override string ToString()
        {
            string info = "";
            for(int i  = 0; i < MyArray.Length; i++)
            {
                info += $"{MyArray[i]} ";
            }
            return info;
        }
    }
}
