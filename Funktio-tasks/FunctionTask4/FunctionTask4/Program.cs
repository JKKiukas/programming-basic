using System;

namespace FunctionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy käyttäjältä 10 positiivista kokonaislukua ja kertoo mikä niistä oli suurin. \n");

            int j = 0;
            Console.WriteLine($"Suurin luku oli {Numbers(ref j)} ja se on rivillä {j}.\n");
            Console.ReadKey();
        }
        static int Numbers(ref int maxIndex)
        {
            int number = 0;
            int max = 0;

            bool isNumber;
            string userInput = "";
            Console.WriteLine("Syötä 10 positiivista lukua. \n ");

            int i = 0;
            while (i < 10)
            {
                Console.Write($"{i + 1}. ");
                isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber && number > 0)
                {
                    userInput += $"{number} ";

                    if (max < number)
                    {
                        max = number;
                        maxIndex = i + 1;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("Väärä syöte. Syötteen täytyy olla positiivinen luku.");
                }
            }
            Console.WriteLine($"\nSyötit seuraavat luvut: {userInput} \n");

            return max;
        }
    }
}