using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Iterators.Task6
{
    public class Lake: IEnumerable<int>
    {
        private List<int> Stones;
        public Lake(List<int> stones)
        {
            Stones = new List<int>(stones);
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new LibraryIterator(Stones);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<int>
        {
            private readonly List<int> Elements;
            private int CurrentIndex;
            public LibraryIterator(IEnumerable<int> elements)
            {
                Reset();
                Elements = new List<int>(elements);
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
            public int Current => Elements[CurrentIndex];
            object IEnumerator.Current => Current;
        }
    }
}
