using Streams.Task3;
using System.Text.RegularExpressions;

namespace Streams
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1.....");
            try
            {
                using (StreamReader reader = new StreamReader("Task1/text.txt"))
                {
                    string line;
                    int index = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (index % 2 != 0)
                        {
                            Console.WriteLine(line);
                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found!");
            }
        }
        static void Task2() 
        {
            Console.WriteLine("Task 2......");
            try
            {
                using (StreamReader reader = new StreamReader("Task1/text.txt")) 
                {
                        string allLines = "";
                        string line;
                        int index = 1;
                        while ((line = reader.ReadLine()) != null) 
                        {
                            allLines += $"Line {index}: " + line + "\n";
                            index++;
                        }
                    using (StreamWriter writer = new StreamWriter("Task2/output.txt")) 
                    {
                        writer.WriteLine(allLines);
                    }
                }
                Console.WriteLine("Output saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found!");
            }
        }
        static void Task3() 
        {
            Console.WriteLine("Task 3.....");
            try
            {
                List<Occurances> words = new List<Occurances>();
                string text = "";
                using (StreamReader reader = new StreamReader("Task3/words.txt")) 
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) 
                    {
                        Occurances word = new Occurances(line);
                        words.Add(word);
                    }
                }
                using (StreamReader reader = new StreamReader("Task1/text.txt")) 
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        text+=line;
                    }
                }
                foreach (Occurances word in words) 
                {
                    int count = Regex.Matches(text, $@"\b{Regex.Escape(word.Word)}\b",RegexOptions.IgnoreCase).Count;
                    word.Occurance = count;
                }
                List<Occurances> sortedWords = words.OrderByDescending(word => word.Occurance).ToList();
                using (StreamWriter writer = new StreamWriter("Task3/result.txt")) 
                {
                    foreach (Occurances c in sortedWords)
                    {
                        writer.WriteLine($"{c.Word} - {c.Occurance}");
                    }
                }
                Console.WriteLine("Result saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found!");
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
