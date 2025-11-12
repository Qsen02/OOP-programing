using StandartStreams.Task2;

namespace StandartStreams
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1.....");
            try
            {
                List<byte> bytes = new List<byte>();
                using (FileStream fs = new FileStream("Task1/image.jpg", FileMode.Open)) 
                {
                    int curByte;
                    while ((curByte = fs.ReadByte())  != -1) 
                    {
                        bytes.Add((byte)curByte);
                    }
                }
                using (FileStream fs = new FileStream("Task1/text.txt", FileMode.Open)) 
                {
                    foreach (byte curByte in bytes) 
                    {
                        fs.WriteByte(curByte);
                    }
                }
                Console.WriteLine("Bytes copied successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine(ex.Message);
            }
        }
        static void Task2() 
        {
            Console.WriteLine("Task 2......");
            FileManipulator.Slice("Task1/image.jpg", "Task2", 5);
            List<string> files = new List<string> {"part-0", "part-1", "part-2", "part-3","part-4" };
            FileManipulator.Assemble(files, "Task2");
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
