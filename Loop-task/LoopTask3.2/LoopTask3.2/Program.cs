using System;

namespace LoopTask3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int luku = 0;
            int i = 1;
            string userInput = Console.ReadLine();

            Console.WriteLine("Ohjelma tulostaa N ensimmäistä lukua yhteen.\n");

            Console.WriteLine("Syötä luku. \n");
            luku = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= luku; i++)
                f = f + i;
            Console.WriteLine($"\nYhteenlaskun tulos on {f}.");
        }
    }
}
