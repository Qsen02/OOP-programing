using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithInterfaces
{
    public class Dog: IAnimal
    {
        public void MakeNoise() 
        {
            Console.WriteLine("Woof!");
        }
        public void MakeTrick() 
        {
            Console.WriteLine("Hold my paw, human!");
        }
        public void Perform() 
        {
            MakeNoise();
            MakeTrick();
        }
    }
}
