using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithInterfaces
{
    public class Cat:IAnimal
    {
        public void MakeNoise() 
        {
            Console.WriteLine("Meow!");
        }
        public void MakeTrick() 
        {
            Console.WriteLine("No trick for you! I'm too lazy!");
        }
        public void Perform() 
        {
            MakeNoise();
            MakeTrick();
        }
    }
}
