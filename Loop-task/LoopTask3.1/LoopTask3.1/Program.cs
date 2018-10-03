using System;

namespace LoopTask3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int f = 1;
            int luku = 0;
            int i = 1;
            string userInput = Console.ReadLine();

            Console.WriteLine("Ohjelma tulostaa N! kertoman arvon.\n");

            Console.WriteLine("Syötä luku. \n");
            luku = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= luku; i++)
                f = f * i;

            if (luku < 1)
                Console.WriteLine("Määrittelemätön.");
            else
                Console.WriteLine($"\nKertoma on {f}.");

            
        }
    }
}