namespace ClassDefinition2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1......");
            RationalNumber1 rational1=new RationalNumber1();
            string numerator=Console.ReadLine();
            int numeratorAsNum = int.Parse(numerator);
            rational1.SetNumerator(numeratorAsNum);
            string denumerator = Console.ReadLine();
            int denumeratorAsNum=int.Parse(denumerator);
            rational1.SetDenumerator(denumeratorAsNum);
            RationalNumber1 rational2 = new RationalNumber1();
            numerator = Console.ReadLine();
            numeratorAsNum = int.Parse(numerator);
            rational2.SetNumerator(numeratorAsNum);
            denumerator = Console.ReadLine();
            denumeratorAsNum = int.Parse(denumerator);
            rational2.SetDenumerator(denumeratorAsNum);
            RationalNumber1 rational3 = new RationalNumber1();
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
    }
}
