using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism3.AbstractClasses
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        public double AnimalWeight { get; set; }
        public int FoodEaten { get; set; }
        public abstract void MakeSound();
        public abstract void Eat(string food,int foodCount);
        public abstract override string ToString();
    }
}
