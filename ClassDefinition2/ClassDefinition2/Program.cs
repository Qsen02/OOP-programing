namespace ClassDefinition2
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Task 1......");
            RationalNumber rational1 = new RationalNumber();
            string numerator = Console.ReadLine();
            int numeratorAsNum = int.Parse(numerator);
            rational1.SetNumerator(numeratorAsNum);
            string denumerator = Console.ReadLine();
            int denumeratorAsNum = int.Parse(denumerator);
            rational1.SetDenumerator(denumeratorAsNum);
            RationalNumber rational2 = new RationalNumber();
            numerator = Console.ReadLine();
            numeratorAsNum = int.Parse(numerator);
            rational2.SetNumerator(numeratorAsNum);
            denumerator = Console.ReadLine();
            denumeratorAsNum = int.Parse(denumerator);
            rational2.SetDenumerator(denumeratorAsNum);
            RationalNumber rational3 = new RationalNumber();
            numerator = Console.ReadLine();
            numeratorAsNum = int.Parse(numerator);
            rational3.SetNumerator(numeratorAsNum);
            denumerator = Console.ReadLine();
            denumeratorAsNum = int.Parse(denumerator);
            rational3.SetDenumerator(denumeratorAsNum);
            Console.WriteLine("{0}/{1}", rational1.GetNumerator(), rational1.GetDenumerator());
            Console.WriteLine("{0}/{1}", rational2.GetNumerator(), rational2.GetDenumerator());
            Console.WriteLine("{0}/{1}", rational3.GetNumerator(), rational3.GetDenumerator());
        }
        static void Task2() 
        {
            Console.WriteLine("Task 2.....");
            string input= Console.ReadLine();
            string[] inputArr = input.Split(" ");
            RationalNumber rational1= new RationalNumber();
            RationalNumber rational2 = new RationalNumber();
            RationalNumber rational3 = new RationalNumber();
            rational1.SetNumerator(int.Parse(inputArr[0]));
            rational1.SetDenumerator(int.Parse(inputArr[1]));
            rational2.SetNumerator(int.Parse(inputArr[2]));
            rational2.SetDenumerator(int.Parse(inputArr[3]));
            rational3.SetNumerator(int.Parse(inputArr[4]));
            rational3.SetDenumerator(int.Parse(inputArr[5]));
            RationalNumber[] numbers = { rational1, rational2, rational3 };
            rational1.Print(numbers);
        }
        static void Task3() 
        {
            Console.WriteLine("Task 3.....");
            string input = Console.ReadLine();
            int[] inputArr = input.Split(" ").Select(el => int.Parse(el)).ToArray();
            RationalNumberWithNod rational1 = new RationalNumberWithNod(inputArr[0], inputArr[1]);
            RationalNumberWithNod rational2 = new RationalNumberWithNod(inputArr[2], inputArr[3]);
            RationalNumberWithNod rational3 = new RationalNumberWithNod(inputArr[4], inputArr[5]);
            RationalNumberWithNod[] numbers = { rational1, rational2, rational3 };
            rational1.Print(numbers);
        }
        static void Task5() 
        {
            Console.WriteLine("Task 5.....");
            string input = Console.ReadLine();
            int[] inputArr = input.Split(" ").Select(el => int.Parse(el)).ToArray();
            EvenNumber evenNumber = new EvenNumber();
            evenNumber.PrintEvenNumbers(inputArr);
        }
        static void Task7()
        {
            Console.WriteLine("Task 7.....");
            string input = Console.ReadLine();
            int[] inputArr = input.Split(" ").Select(el => int.Parse(el)).ToArray();
            OddNumber oddNumber = new OddNumber();
            oddNumber.PrintOddNumbers(inputArr);
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task5();
            Task7();
        }
    }
}
