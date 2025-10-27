namespace PolymorphismWithInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Trainer trainerCat = new Trainer(cat);
            Trainer trainerDog = new Trainer(dog);
            trainerCat.Make();
            trainerDog.Make();
        }
    }
}
