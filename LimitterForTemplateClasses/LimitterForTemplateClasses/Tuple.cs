using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitterForTemplateClasses
{
    public class Tuple<T,K>
    {
        private T Item1;
        private K Item2;

        public Tuple(T item1, K item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
        public T GetFirstItem() 
        {
            return Item1;
        }
        public void SetFirtItem(T item) 
        {
            Item1 = item;
        }
        public K GetSecondItem()
        {
            return Item2;
        }
        public void SetSecondItem(K item)
        {
            Item2 = item;
        }
        public void Print() 
        {
            Console.WriteLine($"{Item1} -> {Item2}");
        }
    }
}
