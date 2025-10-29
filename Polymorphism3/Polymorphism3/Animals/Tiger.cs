using Polymorphism3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism3.Animals
{
    public class Tiger : Mammal
    {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion)
        {
            AnimalName = animalName;
            AnimalType = animalType;
            AnimalWeight = animalWeight;
            FoodEaten = 0;
            LivingRegion = livingRegion;
        }
        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
        public override void Eat(string food, int foodCount)
        {
            if (food == "Meat")
            {
                FoodEaten += foodCount;
            }
            else 
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
        }
        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
