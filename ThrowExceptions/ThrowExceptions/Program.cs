using System.Text.RegularExpressions;

namespace ThrowExceptions
{
    internal class Program
    {
        static void ReadNumbers(int start, int end) 
        {
            string pattern = @"/d+";
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end || Regex.IsMatch(number.ToString(),pattern)) 
            {
                throw new Exception("Invalid number!");
            }
        }
        static void Task1() 
        {
            Console.WriteLine("Task 1.....");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number!");
                }
                if (Regex.IsMatch(number.ToString(), @"/d+")) 
                {
                    throw new FormatException("Invalid number!");
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
        static void Task2() 
        {
            Console.WriteLine("Task 2.....");
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = int.Parse(Console.ReadLine());
            int index = 0;
            while (index != 10)
            {
                try
                {
                    ReadNumbers(start, end);
                    index++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Try again!");
                    index = 0;
                }
            }
            Console.WriteLine("Yeee you did it!");
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
