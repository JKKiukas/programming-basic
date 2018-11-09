using System;

namespace ArrayTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 20];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(100);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i:d2},{j:d2}] = {array[i, j]:d2}");
                }            
            }
        }
    }
}
