using System;

namespace ArrayTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 10 yksiulotteista lukua.\n");

            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(20);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}. {array[i]:d2}");
            }

        }
    }
}
