using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableClasses
{
    public class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings() 
        {
            data = new List<string>();
        }
        public void Push(string item) 
        {
            data.Add(item);
        }
        public void Pop()
        {
            data.RemoveAt(data.Count - 1);
        }
        public string Peek() 
        {
            return data[data.Count - 1];
        }
        public bool IsEmpty() 
        {
            if (data.Count == 0) 
            {
                return true;
            }else 
            {
                return false; 
            }
        }
    }
}
