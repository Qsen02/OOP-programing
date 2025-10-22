namespace LimitterForTemplateClasses
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Task 1.......");
            Scale<int> scale1 = new Scale<int>(3, 5);
            Scale<double> scale2= new Scale<double>(4.5, 3.7);
            Scale<int> scale3=new Scale<int>(10,10);
            Console.WriteLine(scale1.GetHeavier());
            Console.WriteLine(scale2.GetHeavier());
            Console.WriteLine(scale3.GetHeavier());
        }
        static void Task2()
        {
            Console.WriteLine("Task 2.......");
            List<string> commands = new List<string>();
            DetailedList<string> detailedList= new DetailedList<string>();
            string curCommand = "";
            while (curCommand != "END") 
            {
                curCommand = Console.ReadLine();
                commands.Add(curCommand);
            }
            foreach (string command in commands) {
                if (command.Contains("Add"))
                {
                    string[] commandLine = command.Split(' ');
                    string commandValue = commandLine[1];
                    detailedList.Add(commandValue);
                } else if (command.Contains("Remove"))
                {
                    string[] commandLine = command.Split(' ');
                    int commandValue = int.Parse(commandLine[1]);
                    detailedList.Remove(commandValue);
                } else if (command.Contains("Contains")) 
                {
                    string[] commandLine = command.Split(' ');
                    string commandValue = commandLine[1];
                    Console.WriteLine(detailedList.Contains(commandValue));
                }
                else if (command.Contains("Swap"))
                {
                    string[] commandLine = command.Split(' ');
                    int commandValue1 = int.Parse(commandLine[1]);
                    int commandValue2 = int.Parse(commandLine[2]);
                    detailedList.Swap(commandValue1,commandValue2);
                }
                else if (command.Contains("Greater"))
                {
                    string[] commandLine = command.Split(' ');
                    string commandValue = commandLine[1];
                    Console.WriteLine(detailedList.CountGreaterThan(commandValue));
                }
                else if (command.Contains("Max"))
                {
                    Console.WriteLine(detailedList.Max());
                }
                else if (command.Contains("Min"))
                {
                    Console.WriteLine(detailedList.Max());
                }
                else if (command.Contains("Print"))
                {
                    detailedList.Print();
                }
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
