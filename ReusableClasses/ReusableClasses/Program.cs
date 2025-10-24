using System.Collections;

namespace ReusableClasses
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1.....");
            ArrayList fruits = new ArrayList() { "apple", "pineapple", "strawberry", "grapes" };
            RandomList randomList = new RandomList(fruits);
            Console.WriteLine(randomList.RandomString());
        }
        static void Task2()
        {
            Console.WriteLine("Task 2.....");
            StackOfStrings strings= new StackOfStrings();
            Console.WriteLine(strings.IsEmpty());
            strings.Push("tomato");
            strings.Push("cucumber");
            strings.Push("watermelon");
            strings.Pop();
            Console.WriteLine(strings.Peek());
            Console.WriteLine(strings.IsEmpty());
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
