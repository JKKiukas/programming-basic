using System;

namespace LoopTask4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9 \n");

            int number1 = 1;
            int number2 = 1;
            int answer = 1;

            for (number1 = 1; number1 <= 9; number1++)
            {
                for (number2 = 1; number2 <= 9; number2++)
                {
                    answer = number1 * number2;
                    Console.WriteLine($"{number1} * {number2} = {answer}");

                }
            }
        }
    }
}