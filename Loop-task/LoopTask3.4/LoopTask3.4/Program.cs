using System;

namespace LoopTask3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int luku = 0;
            int i = 0;
            string userInput = Console.ReadLine();

            Console.WriteLine("Ohjelma tulostaa N ensimmäistä lukua yhteen.\n");

            Console.Write("Syötä luku: ");
            luku = int.Parse(Console.ReadLine());

            if (luku > 0)
                for (i = 1; i <= luku; i++)
                f = f + i;
            else
                for (i = 0; i >= luku; i--)
                    f = f + i;
            Console.WriteLine($"\nYhteenlaskun tulos on {f}.");

            
        }
    }
}
