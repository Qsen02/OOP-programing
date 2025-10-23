using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitterForTemplateClasses
{
    public class Threeuple<T,K,U>
    {
        private T Item1;
        private K Item2;
        private U Item3;
        public Threeuple(T item1, K item2, U item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
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
        public U GetThirdItem()
        {
            return Item3;
        }
        public void SetThirdItem(U item)
        {
            Item3 = item;
        }
        public void Print()
        {
            Console.WriteLine($"{Item1} -> {Item2} -> {Item3}");
        }
    }
}
