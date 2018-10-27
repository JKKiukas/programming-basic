using System;

namespace Self_assessment_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy käyttäjää syöttämään sanan tai lauseen ja tulostaa sen niin monta kertaa näytölle kuin sanassa on kirjaimia. \n");
            Console.WriteLine("Syötä sana tai lause. \n");

            string userInput = Console.ReadLine();
            int letterCount = 1;
            foreach (char letter in userInput)
            
            {
                letterCount++;
            }
            for (int i = 1; i < letterCount; i++)
            {
                Console.Write($"\n{i}. ");
                Console.WriteLine($"{userInput}");
            }
        }
    }
}
