namespace TemplateClasses
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1......");
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());
        }
        static void Task2()
        {
            Console.WriteLine("Task 2......");
            Box<object> box = new Box<object>();
            box.Add(123123);
            box.Add("Life in a box");
            box.ToString();
        }
        static void Task3()
        {
            Console.WriteLine("Task 3......");
            Box<System.String> box = new Box<System.String>();
            string n=Console.ReadLine();
            int nAsNum = int.Parse(n);
            for (int i = 0; i < nAsNum; i++) 
            {
                string input=Console.ReadLine();
                box.Add(input);
            }
            box.ToString();
        }
        static void Task4()
        {
            Console.WriteLine("Task 4......");
            Box<int> box = new Box<int>();
            string n = Console.ReadLine();
            int nAsNum = int.Parse(n);
            for (int i = 0; i < nAsNum; i++)
            {
                string input = Console.ReadLine();
                int inputAsNum=int.Parse(input);
                box.Add(inputAsNum);
            }
            box.ToString();
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}
