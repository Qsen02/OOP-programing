using Iterators.Task1And2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comapators.Task1And2
{
    public class BookComaprator: IComparer<Book>
    {
        public int Compare(Book x, Book y) 
        {
            int result=x.Year.CompareTo(y.Year);
            if (result == 0) 
            {
                result = x.Title.CompareTo(y.Title);
            }
            return result;
        }
    }
}
