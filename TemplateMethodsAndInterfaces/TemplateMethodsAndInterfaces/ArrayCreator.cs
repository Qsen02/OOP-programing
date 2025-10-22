using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodsAndInterfaces
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T items)
        {
            T[] array=new T[length];
            array[0] = items;
            return array;
        }
        public static T[] CreateEmptyArray<T>(int length) 
        {
            T[] array = new T[length];
            return array;
        }
        public static T[] SwapElements<T>(int firstIndex, int secondIndex, T[] array) 
        {
            T temp=array[firstIndex];
            array[firstIndex]=array[secondIndex];
            array[secondIndex]=temp;
            return array;
        }
        public static void Print<T>(T[] array) 
        {
            foreach (T item in array)
            {
                Console.WriteLine($"{item.GetType().FullName}: {item}");
            }
        }
        public static int ElementCounting<T>(List<T> list, T element)
        {
            int count = 0;
            dynamic dyElement = element;
            if (typeof(T) == typeof(string))
            {
                 count = list.Count(el => (dynamic)dyElement.Length > dyElement.Length);
            }
            else if(typeof(T) == typeof(double)){
                count = list.Count(el => el > dyElement);
            }
            return count;
        }
    }
}
