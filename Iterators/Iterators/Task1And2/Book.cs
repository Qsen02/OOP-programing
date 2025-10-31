using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators.Task1And2
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }
        public Book(string title,int year, params string[] authors) 
        {
            Title = title;
            Year = year;
            Authors = authors;
        }
    }
}
