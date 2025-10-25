using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    public class Citizen1:IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Citizen1(string name,int age) 
        {
            Name = name;
            Age = age;
        }
    }
}
