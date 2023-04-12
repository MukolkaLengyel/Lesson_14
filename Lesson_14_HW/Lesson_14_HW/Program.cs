using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Lesson_14_HW
{
    internal class Program
    {
        //Generic Stack<T> Class
        public class Stack<T>
        {
            internal T[] _items;
            internal int _top;

            public Stack()
            {
                _items = new T[5];
                _top = -1;
            }

            //Push(obj), adds obj at the top of stack
            public void Push(T obj)
            {
                this.stack.Add(obj);
            }

            //Pop, returns top element of stack & removes it
            public void Pop()
            {
                if ( _top == -1)
                {
                    var PopItem = _items[_top];
                    _top--;
                    _items[_top] = PopItem;
                    return PopItem;
                }
            }

            //Clear() - clear stack
            public void Clear()
            {
                Array.Clear(_items, 0, _items.Length);
                _top = -1;
            }

            //Count - property return number of elements
            public int Count()
            {
                var count = _top + 1;
                return count;
            }

            
            //Peek() - returns top element but doesn’t remove it
            public void Peek()
            {
                if (_top == -1)
                {
                    var PeekItem = _items[_top];
                    PeekItem = _items[_top];
                }
            }

            //CopyTo(arr) - copies stack to array
            public void CopyTo(T[] arr, int index)
            {
                this.stack.CopyTo(arr, index);
            }
        }
    }
}