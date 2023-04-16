using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Lesson_14_HW
{
    internal class Program
    {
      
    public class Stack<T>
    {
    private List<T> items = new List<T>();

    public void Push(T obj)
    {
        items.Add(obj);
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T obj = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return obj;
    }

    public void Clear()
    {
        items.Clear();
    }

    public int Count
    {
        get { return items.Count; }
    }

    public T Peek()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return items[items.Count - 1];
    }

    public void CopyTo(T[] arr)
    {
        if (arr == null)
        {
            throw new ArgumentNullException(nameof(arr));
        }

        items.CopyTo(arr);
    }
   }

  }
}
