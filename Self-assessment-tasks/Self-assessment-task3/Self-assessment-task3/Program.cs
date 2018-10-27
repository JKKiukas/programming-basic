using System;

namespace Self_assessment_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy käyttäjältä lukuja, kunnes hän syöttää luvun -1. Ohjelma tulostaa näytölle syötettyjen lukujen yhteenlaskun. \n");
            Console.WriteLine("Syötä luku(ja). \n");

            int add = 0;

            while(true)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (isNumber && userInput != -1)
                {
                    add += userInput;
                }
                else if (isNumber && userInput == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Syötteen on oltava numero");
                }
            }
            Console.WriteLine($"\nYhteenlaskun tulos on {add}");
        }
    }
}
