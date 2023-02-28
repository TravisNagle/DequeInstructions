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
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DequeInstructions
{
    public class MyDeque<T> : IStack<T>, IQueue<T>
    {
        private T[] MyArray { get; set; }
        private int _stackCount;
        private int _currentLocation;
        private int _queueCount;
        private int totalCount = 0;

        public MyDeque(int maxSize = 10)
        {
            MyArray = new T[maxSize];
            CurrentLocation = MyArray.Length - 1;
        }

        public int StackCount
        {
            get 
            { 
                return _stackCount; 
            }
            set 
            { 
                _stackCount = Math.Max(0, value); 
            }
        }

        
        public int QueueCount
        {
            get
            {
                return _queueCount;
            }
            set
            {
                _queueCount = value;
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

        public T Dequeue()
        {
            QueueCount--;
            T result = MyArray[QueueCount];
            return result;
        }
        
        public void Enqueue(T item)
        {
            MyArray[CurrentLocation] = item;
            CurrentLocation--;
        }

        public T Peek()
        {
            if (StackCount == 0)
            {
                return default(T);
            }
            return MyArray[StackCount - 1];
        }

        public T Pop()
        {
            if(StackCount == 0)
            {
                return default(T);
            }
            StackCount--;
            T result = MyArray[StackCount];
            totalCount--;
            return result;
        }

        public void Push(T item)
        {
            MyArray[StackCount] = item;
            StackCount++;
            totalCount++;
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
