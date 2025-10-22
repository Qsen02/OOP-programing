namespace TemplateMethodsAndInterfaces
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1.....");
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
        }
        static void Task2()
        {
            Console.WriteLine("Task 2.....");
            int length=int.Parse(Console.ReadLine());
            string[] array = ArrayCreator.CreateEmptyArray<string>(length);
            for (int i = 0; i < length; i++) 
            {
                string input=Console.ReadLine();
                array[i] = input;
            }
            int[] indexesToSwap=Console.ReadLine().Split(" ").Select(el=>int.Parse(el)).ToArray();
            string[] swappedArray = ArrayCreator.SwapElements(indexesToSwap[0], indexesToSwap[1], array);
            ArrayCreator.Print(swappedArray);
        }
        static void Task3() 
        {
            Console.WriteLine("Task 3.....");
            int length = int.Parse(Console.ReadLine());
            int[] array = ArrayCreator.CreateEmptyArray<int>(length);
            for (int i = 0; i < length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                array[i] = input;
            }
            int[] indexesToSwap = Console.ReadLine().Split(" ").Select(el => int.Parse(el)).ToArray();
            int[] swappedArray = ArrayCreator.SwapElements(indexesToSwap[0], indexesToSwap[1], array);
            ArrayCreator.Print(swappedArray);
        }
        static void Task4()
        {
            Console.WriteLine("Task 4.....");
            int length = int.Parse(Console.ReadLine());
            string[] array = ArrayCreator.CreateEmptyArray<string>(length);
            for (int i = 0; i < length; i++)
            {
                string input = Console.ReadLine();
                array[i] = input;
            }
            string elementForCount = Console.ReadLine();
            int count = ArrayCreator.ElementCounting<string>(array.ToList(), elementForCount);
            Console.WriteLine(count);
        }
        static void Task5()
        {
            Console.WriteLine("Task 5.....");
            int length = int.Parse(Console.ReadLine());
            double[] array = ArrayCreator.CreateEmptyArray<double>(length);
            for (int i = 0; i < length; i++)
            {
                double input = double.Parse(Console.ReadLine());
                array[i] = input;
            }
            double elementForCount = double.Parse(Console.ReadLine());
            int count = ArrayCreator.ElementCounting<double>(array.ToList(), elementForCount);
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}
