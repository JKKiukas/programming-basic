using System;

namespace LoopTask4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma heittää noppaa 1000 kertaa ja kertoo montako kertaa numero kuusi heitettiin. \n");

            Random dice = new Random();
            int result;
            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                result = dice.Next(6) + 1;
                if (result == 6)
                    count++;
                Console.WriteLine($"{i + 1} {result}");
            }
            Console.WriteLine($"Numero kuusi arvottiin {count} kertaa");
        }
    }
}
