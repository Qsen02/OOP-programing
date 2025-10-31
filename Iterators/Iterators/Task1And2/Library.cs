using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Iterators.Task1And2
{
    public class Library: IEnumerable<Book>
    {
        private List<Book> Books;
        public Library(params Book[] books) 
        {
            Books=new List<Book>(books);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book> 
        {
            private readonly List<Book> Books;
            private int CurrentIndex;
            public LibraryIterator(IEnumerable<Book> books) 
            {
                Reset();
                Books = new List<Book>(books);
            }
            void IDisposable.Dispose() { }
            public bool MoveNext() 
            {
                return ++CurrentIndex < Books.Count;
            }
            public void Reset()
            {
                CurrentIndex = -1;
            }
            public Book Current => Books[CurrentIndex];
            object IEnumerator.Current=>Current;
        }
    }
}
