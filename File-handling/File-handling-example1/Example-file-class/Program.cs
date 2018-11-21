using System;
using System.IO;

namespace Example_file_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read in every line in specified file.
            // ... This will store all lines in an array in memory.
            string[] lines = File.ReadAllLines(@"C:\TEMP\TESTI.DAT");
            foreach (string line in lines)
            {
                // Do something with the line.
                Console.WriteLine(line);
                if (line.Length > 80)
                {
                    // Important code.
                }
            }
        }
    }
}