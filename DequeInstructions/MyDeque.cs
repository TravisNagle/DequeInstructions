﻿///////////////////////////////////////////////////////////////////////////////
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
    /// <summary>
    /// Implementation of the MyDeque class which allows for items to be pulled from the front and back
    /// </summary>
    /// <typeparam name="T">Generic data type</typeparam>
    public class MyDeque<T> : IStack<T>, IQueue<T>
    {
        private T[] MyArray { get; set; }
        private int _stackCount;
        private int _currentLocation;
        private int _queueCount;
        private int totalCount = 0;

        /// <summary>
        /// Default constructor for the MyDeque object which sets up the size of the internal array
        /// </summary>
        /// <param name="maxSize">Size of the array</param>
        public MyDeque(int maxSize = 10)
        {
            MyArray = new T[maxSize];
            CurrentLocation = MyArray.Length - 1;
        }

        /// <summary>
        /// Keeps track of the location within the array with stack functions
        /// </summary>
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

        /// <summary>
        /// Looks at the next item in the array without incrementing the counters
        /// </summary>
        /// <returns>The next value in line</returns>
        public T Peek()
        {
            if (StackCount == 0)
            {
                return default(T);
            }
            return MyArray[StackCount - 1];
        }

        /// <summary>
        /// Pop method which pulls a value from the front of the array
        /// </summary>
        /// <returns>Value in front of line</returns>
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

        /// <summary>
        /// Push method that places a new value in the front of the array
        /// </summary>
        /// <param name="item">Item to be placed in line</param>
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
