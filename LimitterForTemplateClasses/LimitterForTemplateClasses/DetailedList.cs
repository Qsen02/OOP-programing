using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitterForTemplateClasses
{
    public class DetailedList<T> where T: IComparable<T>
    {
        private List<T> Items;
        public DetailedList()
        {
            Items = new List<T>();
        }
        public List<T> GetItmes() 
        {
            return Items;
        }
        public void SetItems(List<T> newItems) 
        {
            Items=newItems;
        }
        public void Add(T item)
        {
            Items.Add(item);
        }
        public T Remove(int index) 
        {
            T itemToRemove=Items[index];
            Items.RemoveAt(index);
            return itemToRemove;
        }
        public bool Contains(T item)
        {
            return Items.Contains(item);
        }
        public void Swap(int index1, int index2) 
        {
            T temp=Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = temp;
        }
        public int CountGreaterThan(T item)
        {
            int count = Items.Count(el => el.CompareTo(item) > 0);
            return count;
        }
        public T Max() 
        {
            return Items.Max();
        }

        public T Min() 
        {
            return Items.Min();
        }

        public void Print() 
        {
            foreach (T item in Items) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
