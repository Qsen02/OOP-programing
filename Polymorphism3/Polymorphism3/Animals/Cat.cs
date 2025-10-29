using Polymorphism3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism3.Animals
{
    public class Cat : Mammal
    {
        public string Breed { get; set; }
        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed)
        {
            AnimalName = animalName;
            AnimalType = animalType;
            AnimalWeight = animalWeight;
            FoodEaten = 0;
            LivingRegion = livingRegion;
            Breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }
        public override void Eat(string food, int foodCount)
        {
                FoodEaten += foodCount;
        }
        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
