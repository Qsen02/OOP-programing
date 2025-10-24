using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableClasses
{
    public class RandomList : ArrayList
    {
        private ArrayList list;

        public RandomList(ArrayList items) 
        {
            list = items;
        }

        public string RandomString() 
        {
            Random rnd= new Random();
            int index = rnd.Next(0, list.Count - 1);
            string randomElement = (string)list[index];
            list.RemoveAt(index);
            return randomElement;
        }
    }
}
