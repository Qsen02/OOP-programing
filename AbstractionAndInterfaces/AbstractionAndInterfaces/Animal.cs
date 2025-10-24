using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterfaces
{
    public abstract class Animal: IMakeNoise, IMakeTrick
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void MakeNoise() 
        {
            Console.WriteLine($"{Name} {Age}");
        }
        public virtual void MakeTrick() 
        {
            Console.WriteLine("Look at my trick!");
        }
    }
}
