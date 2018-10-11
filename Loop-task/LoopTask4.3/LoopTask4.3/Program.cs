using System;

namespace LoopTask4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista lukua väliltä 0-50 \n");

            Random rnd = new Random();
            int rndNumber = 1;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Rivi {i}. ");
                for (int l = 1; l <= 5; l++)
                {
                    rndNumber = rnd.Next(51);
                    if (l == 5)
                        Console.WriteLine($"{rndNumber}");
                    else
                        Console.Write($"{rndNumber}, ");
                }
            }
        }
    }
}
