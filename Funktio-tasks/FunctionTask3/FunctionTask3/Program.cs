using System;

namespace FunctionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää käyttäjää syöttämään luvun väliltä 1-50. Jos syöte on virheellinen, lukua pyydetään uudestaan. \n");
            int number = numberCompare(1, 50);
            Console.WriteLine($"Syöttämäsi luku {number} on väliltä 1-50.");
        }
        static int numberCompare(int lower, int upper)
        {
            int permittedNumber;
            while (true)
            {
                Console.WriteLine("Syötä luku: \n");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);
                if (isNumber && userInput >= lower && userInput <= upper)
                {
                    permittedNumber = userInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte");
                }
            }
            return permittedNumber;
        }
    }
}
