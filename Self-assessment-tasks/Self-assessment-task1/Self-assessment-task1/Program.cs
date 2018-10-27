using System;

namespace Self_assessment_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy käyttäjältä sanan tai lauseen ja tulostaa sen 5 kertaa. \n");
            Console.WriteLine("Syötä sana tai lause. \n");

            string userInput = Console.ReadLine();

            for (int i = 1; i < 6; i++)
            {
                Console.Write($"\n{i}. ");
                Console.WriteLine($"{userInput}");
            }
        }
    }
}
