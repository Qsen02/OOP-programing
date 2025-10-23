using System.Diagnostics;

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
        static void Task2And3()
        {
            Console.WriteLine("Task 2 and 3.......");
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
                }
                else if (command.Contains("Remove"))
                {
                    string[] commandLine = command.Split(' ');
                    int commandValue = int.Parse(commandLine[1]);
                    detailedList.Remove(commandValue);
                }
                else if (command.Contains("Contains"))
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
                    detailedList.Swap(commandValue1, commandValue2);
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
                    Console.WriteLine(detailedList.Min());
                }
                else if (command.Contains("Print"))
                {
                    detailedList.Print();
                }
                else if (command.Contains("Sort")) 
                {
                    List<string> sortedList=Sorter.Sort<string>(detailedList);
                    detailedList.SetItems(sortedList);
                }
            }
        }
        static void Task5() 
        {
            Console.WriteLine("Task 5.......");
            string[] firstLine = Console.ReadLine().Split(" ");
            string fullName=firstLine[0]+" "+firstLine[1];
            Tuple<string,string> tuple1 = new Tuple<string,string>(fullName, firstLine[2]);
            string[] secondLine = Console.ReadLine().Split(" ");
            int litersBeer=int.Parse(secondLine[1]);
            Tuple<string,int> tuple2 = new Tuple<string, int>(secondLine[0], litersBeer);
            string[] thirdLine = Console.ReadLine().Split(" ");
            int num1=int.Parse(thirdLine[0]);
            double num2=double.Parse(thirdLine[1]);
            Tuple<int, double> tuple3 = new Tuple<int, double>(num1, num2);
            tuple1.Print();
            tuple2.Print();
            tuple3.Print();
        }

        static void Task6() 
        {
            Console.WriteLine("Task 6.......");
            string[] firstLine = Console.ReadLine().Split(" ");
            string fullName = firstLine[0] + " " + firstLine[1];
            Threeuple<string, string,string> threeuple1 = new Threeuple<string, string,string>(fullName, firstLine[2], firstLine[3]);
            string[] secondLine = Console.ReadLine().Split(" ");
            int litersBeer = int.Parse(secondLine[1]);
            bool isDrunk = false;
            if (secondLine[2] == "drunk")
            {
                isDrunk = true;
            }
            else 
            {
                isDrunk = false;
            }
            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>(secondLine[0], litersBeer, isDrunk);
            string[] thirdLine = Console.ReadLine().Split(" ");
            double accountBalance=double.Parse(thirdLine[1]);
            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(thirdLine[0], accountBalance, thirdLine[2]);
            threeuple1.Print();
            threeuple2.Print();
            threeuple3.Print();
        }
        static void Main(string[] args)
        {
            Task1();
            Task2And3();
            Task5();
            Task6();
        }
    }
}
