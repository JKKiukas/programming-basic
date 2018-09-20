using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku parillinen vai pariton");
            Console.Write("Syötä numero ");
            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"Luku {number} on parillinen");
                else
                    Console.WriteLine($"Luku {number} on pariton");
            }
            else
                Console.WriteLine("Väärä syöte! ");

            //Console.WriteLine("Luku {0} on parillinen", number);
            //Console.WriteLine("Luku " + number + " on parillinen");
        }
    }
}
