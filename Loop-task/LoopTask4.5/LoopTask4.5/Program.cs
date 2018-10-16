using System;

namespace LoopTask4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin. \n");

            Random roll = new Random();
            double result;

            for (int i = 1; i < 14; i++)
            { result = roll.NextDouble();
                if (result < 0.4)
                    Console.WriteLine("Kotivoitto");
                else if (result > 0.4 && result < 0.6)
                    Console.WriteLine("Tasapeli");
                else
                    Console.WriteLine("Vierasvoitto");
            }
        }
    }
}
