using System;

namespace IfTasks1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko annettu luku positiivinen, negatiivinen vai nolla");
            Console.Write("Syötä luku: ");
            string userInput =  Console.ReadLine();
            int number = int.Parse(userInput);

            if(number == 0)
                Console.WriteLine($"Numero {number} on nolla");
            else if(number<0)
                Console.WriteLine($"Numero {number} on negatiivinen");
            else
                Console.WriteLine($"Numero {number} on positiivinen");

            Console.WriteLine($"Syötit luvun {userInput}");
        }
    }
}
