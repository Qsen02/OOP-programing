namespace Inheritance
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1......");
            Dog dog= new Dog();
            dog.Eat();
            dog.Bark();
        }
        static void Task2()
        {
            Console.WriteLine("Task 2......");
            Puppy puppy= new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
        static void Task3() 
        {
            Console.WriteLine("Task 3......");
            Dog dog=new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat=new Cat();
            cat.Eat();
            cat.Meow();
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
