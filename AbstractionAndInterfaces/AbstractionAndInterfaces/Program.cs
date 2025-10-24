namespace AbstractionAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Pesho", 5);
            Dog dog = new Dog("Gosho", 10);

            cat.MakeNoise();
            cat.MakeTrick();

            dog.MakeNoise();
            dog.MakeTrick();
        }
    }
}
