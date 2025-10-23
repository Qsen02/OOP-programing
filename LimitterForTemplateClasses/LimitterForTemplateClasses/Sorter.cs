using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitterForTemplateClasses
{
    public class Sorter
    {
        public static List<T> Sort<T>(DetailedList<T> items) where T : IComparable<T>
        {
            List<T> sortedItems=items.GetItmes().OrderBy(el=>el).ToList();
            return sortedItems;
        }
    }
}
