using System;

namespace LoopTask3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int EvenSum = 0;
            int OddSum = 0;
            int i = 1;

            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen lukujen summan. \n");
            Console.WriteLine("Syötä luku. \n");

            int number = int.Parse(Console.ReadLine());

            if (i < number)
                for (i = 1; i <= number; i++)
                    if (i % 2 == 0)
                        EvenSum = EvenSum + i;
                    else
                        OddSum = OddSum + i;
           
            Console.WriteLine($"Parittomien summa on {OddSum} Parillisten summa on {EvenSum}");

        }
    }
}