using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeInstructions
{
    public interface IStack<T>
    {
        public T Pop();
        public void Push(T item);
        public T Peek();
    }
}
