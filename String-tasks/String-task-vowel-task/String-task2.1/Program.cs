using System;

namespace String_task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syötteestä vokaalien lukumäärän.\n");
            Console.WriteLine("Anna syöte.\n");

            string userInput = Console.ReadLine();
            int vowelCounter = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u' || userInput[i] == 'y' || userInput[i] == 'ä' || userInput[i] == 'ö')
                {
                    vowelCounter++;
                }               
            }
            Console.WriteLine($"\nSanassa {userInput} on {vowelCounter} vokaalia.");
        }
    }
}
