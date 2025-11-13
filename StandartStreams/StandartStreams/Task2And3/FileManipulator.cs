using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartStreams.Task2
{
    public class FileManipulator
    {
        public static void Slice(string sourceFile,string destinationDirectory,int parts) 
        {
            try
            {
                Directory.CreateDirectory(destinationDirectory);
                using (FileStream source = new FileStream(sourceFile, FileMode.Open))
                {
                    List<byte> bytes = new List<byte>();
                    int curByte;
                    while ((curByte = source.ReadByte()) != -1)
                    {
                        bytes.Add((byte)curByte);
                    }
                    int onePartBytes = bytes.Count / parts;
                    int curBytes = 0;
                    for (int i = 0; i < parts; i++)
                    {
                        string destinationPath = Path.Combine(destinationDirectory,$"part-{i}.gz");
                        using (FileStream destination = new FileStream(destinationPath, FileMode.Create,FileAccess.Write))
                        {
                            using var compressor = new GZipStream(destination, CompressionMode.Compress);
                            for (int j = curBytes; j < curBytes + onePartBytes; j++)
                            {
                                destination.WriteByte(bytes[j]);
                            }
                        }
                    }
                }
                Console.WriteLine("File divided successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine(e.Message);
            }
        }
        public static void Assemble(List<string> files,string destinationDirectory) 
        {
            try
            {
                Directory.CreateDirectory(destinationDirectory);
                foreach (string file in files)
                {
                    using (FileStream source = new FileStream($"Task2/{file}.gz", FileMode.Open))
                    {
                        using var decompressor = new GZipStream (source, CompressionMode.Decompress);
                        List<byte> bytes = new List<byte>();
                        int curByte;
                        while ((curByte = source.ReadByte()) != -1)
                        {
                            bytes.Add((byte)curByte);
                        }
                        string destinationPath = Path.Combine(destinationDirectory, "mergedFile");
                        using (FileStream destination = new FileStream(destinationPath, FileMode.Append,FileAccess.Write))
                        {
                            foreach (byte b in bytes)
                            {
                                destination.WriteByte(b);
                            }
                        }
                    }
                }
                Console.WriteLine("File merged successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
