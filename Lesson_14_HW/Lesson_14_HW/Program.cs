﻿using System.Collections;
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
            public void Push (T obj) 
            {
                if (_top == _items.Length - 1) 
                { 
                    Array.Resize(ref _items, _items.Length * 2);
                    _top++;
                    _items[_top] = obj;    
                }
            }

            //Pop, returns top element of stack & removes it
            public void Pop()
            {
                if ( _top == -1)
                {
                    var PopItem = _items[_top];
                    _top--;
                    _items[_top] = PopItem;
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
                Array.Copy(_items, arr, index);
            }
        }
    }
}