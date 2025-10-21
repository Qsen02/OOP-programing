using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses
{
    public class Box<T>
    {
        private Stack<T> Elements;
        public int Count { get; set; }
        public Box() 
        {
            this.Elements = new Stack<T>();
            this.Count = 0;
        }
        public void Add(T element)
        {
            this.Elements.Push(element);
            this.Count++;
        }
        public T Remove() 
        {
            T element = this.Elements.Pop();
            this.Count--;
            return element;
        }
        public void ToString() 
        {
            foreach (T element in this.Elements) 
            {
                Console.WriteLine($"{element.GetType().FullName}: {element}");
            }
        }
    }
}
