using Polymorphism3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism3.Animals
{
    public class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, string livingRegion)
        {
            AnimalName = animalName;
            AnimalType = animalType;
            AnimalWeight = animalWeight;
            FoodEaten = 0;
            LivingRegion = livingRegion;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }
        public override void Eat(string food, int foodCount)
        {
            if (food != "Vegetable")
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
            else
            {
                FoodEaten += foodCount;
            }
        }
        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
