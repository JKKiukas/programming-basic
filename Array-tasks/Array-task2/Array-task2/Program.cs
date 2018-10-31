using System;
using System.Linq;

namespace Array_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo sata lukua väliltä 0-50. Arvotut luvut näytetään ja keskiarvo kerrotaan käyttäjälle.\n");

            double[] numbers = new double[100];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(50);
            }

            double sum = numbers.Sum();
            double average = sum / 100;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i+1}. {numbers[i]}");
            }

            Console.WriteLine($"\nKeskiarvo on {average}");
        }
    }
}
