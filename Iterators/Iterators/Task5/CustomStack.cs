using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators.Task5
{
    public class CustomStack<T>:IEnumerable<T>
    {
        private List<T> Elements;
        public CustomStack()
        {
            Elements = new List<T>();
        }
        public void Push(T item) 
        {
            Elements.Add(item);
        }
        public void Pop() 
        {
            if (Elements.Count > 0)
            {
                Elements.RemoveAt(Elements.Count - 1);
            }
            else 
            {
                Console.WriteLine("No elements");
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new LibraryIterator(Elements);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<T>
        {
            private readonly List<T> Elements;
            private int CurrentIndex;
            public LibraryIterator(IEnumerable<T> elements)
            {
                Reset();
                Elements = new List<T>(elements);
            }
            public void Dispose() { }
            public bool MoveNext()
            {
                return ++CurrentIndex < Elements.Count;
            }
            public void Reset()
            {
                CurrentIndex = -1;
            }
            public T Current => Elements[CurrentIndex];
            object IEnumerator.Current => Current;
        }
    }
}
