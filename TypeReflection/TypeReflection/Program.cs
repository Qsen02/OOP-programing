using System.Net;
using System.Reflection;
using System.Text;
using TypeReflection.Task1;

namespace TypeReflection
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1.....");
            Spy spy=new Spy();
            string result = spy.StealFieldsInfo("Hacker", "username", "password");
            Console.WriteLine(result);
            string newResult = spy.AnalyzeAcessModifiers("Hacker");
            Console.WriteLine(newResult);
            string privateMethods = spy.RevealPrivateMethods("Hacker");
            Console.WriteLine(privateMethods);
            string gettersAndSetters = spy.CollectGettersAndSetters("Hacker");
            Console.WriteLine(gettersAndSetters);
        }
        static void Task2()
        {
            Console.WriteLine("Task 2.....");
            List<string> commands=new List<string>();
            string command = "";
            while (command != "HARVEST") 
            {
                command = Console.ReadLine();
                commands.Add(command);
            }
            foreach (string curCommand in commands) 
            {
                Type classType = Type.GetType("TypeReflection.Hacker");
                StringBuilder stringBuilder = new StringBuilder();
                switch (curCommand) 
                {
                    case "public":
                        FieldInfo[] publicFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);
                        foreach (FieldInfo field in publicFields)
                        { 
                            stringBuilder.AppendLine($"public {field.FieldType} {field.Name}");
                        }
                        Console.WriteLine(stringBuilder.ToString().Trim());
                        break;

                    case "private":
                        FieldInfo[] privateFields = classType.GetFields(BindingFlags.Instance | 
                            BindingFlags.NonPublic)
                            .Where((f) => f.IsPrivate).ToArray();
                        foreach (FieldInfo field in privateFields)
                        {
                            stringBuilder.AppendLine($"private {field.FieldType} {field.Name}");
                        }
                        Console.WriteLine(stringBuilder.ToString().Trim());
                        break;

                    case "protected":
                        FieldInfo[] protectedFields = classType.GetFields(BindingFlags.Instance | 
                            BindingFlags.NonPublic)
                            .Where((f)=>f.IsFamily).ToArray();
                        foreach (FieldInfo field in protectedFields)
                        {
                            stringBuilder.AppendLine($"protected {field.FieldType} {field.Name}");
                        }
                        Console.WriteLine(stringBuilder.ToString().Trim());
                        break;

                    case "all":
                        FieldInfo[] allFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        foreach (FieldInfo field in allFields)
                        {
                            string modifier = field.IsPublic ? "public" 
                                : field.IsPrivate?"private"
                                : field.IsFamily ?"protected"
                                :"";
                            stringBuilder.AppendLine($"{modifier} {field.FieldType} {field.Name}");
                        }
                        Console.WriteLine(stringBuilder.ToString().Trim());
                        break;
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
