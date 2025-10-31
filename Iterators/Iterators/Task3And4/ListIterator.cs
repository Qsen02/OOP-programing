using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators.Task3And4
{
    public class ListIterator<T>
    {
        private List<T> Elements;
        private int CurrentIndex;
        public ListIterator(List<T> elements) 
        {
            Elements = [..elements];
            CurrentIndex = 0;
        }
        public bool Move() 
        {
            if (HasNext()) 
            {
                this.CurrentIndex++;
                return true;
            }
            return false;
        }
        public bool HasNext() 
        {
            return this.CurrentIndex + 1 < Elements.Count;
        } 
        public void Print() 
        {
            if (Elements.Count > 0)
            {
                Console.WriteLine(Elements[this.CurrentIndex]);
            }
            else 
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}
