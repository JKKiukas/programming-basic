using System;
using System.Collections.Generic;

namespace Self_assessment_task4
{
    class Program
    {
        static void Main(string[] args)
        {
           Intro(out double x, out double y);
        }
         static void Intro(out double number1, out double number2)

         {
             Console.WriteLine("Ohjelma pyytää käyttäjää syöttämään kaksi lukua. Tämän jälkeen ohjelma laskee yhteen- vähennys- jako- ja kertolaskun" +
             "\nannetuista luvuista. \n");
             Console.Write("Syötä 1. luku: ");
             number1 = double.Parse(Console.ReadLine());
             Console.Write("\nSyötä 2. luku: ");
             number2 = double.Parse(Console.ReadLine());

            {
                double result = number1 + number2;
                double result1 = number1 - number2;
                double result2 = number1 / number2;
                double result3 = number1 * number2;

                Console.WriteLine($"\n{number1} + {number2} = {result}");
                Console.WriteLine($"{number1} - {number2} = {result1}");
                Console.WriteLine($"{number1} / {number2} = {result2}");
                Console.WriteLine($"{number1} * {number2} = {result3}");
            }
         }
    }
}
