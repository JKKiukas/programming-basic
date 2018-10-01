using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko annettu luku positiivinen, negatiivinen vai nolla. Ohjelma selvittää myös onko annettu luku pariton vai parillinen");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (number == 0)
                 Console.WriteLine($"Numero {number} on nolla");
            else if (number < 0)
                 Console.WriteLine($"Numero {number} on negatiivinen");
            else
                 Console.WriteLine($"Numero {number} on positiivinen");

            if (isNumber)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"Luku {number} on parillinen");
                else
                    Console.WriteLine($"Luku {number} on pariton");
            }
            else
                Console.WriteLine("Väärä syöte");

            Console.WriteLine($"Syötit luvun {userInput}");

        }
    }
}
