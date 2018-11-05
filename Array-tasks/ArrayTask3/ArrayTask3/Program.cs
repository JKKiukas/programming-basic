using System;

namespace ArrayTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo käyttäjälle lottorivin.\n");

            Random rnd = new Random();
            int[] lotto = new int[40];

            for (int i = 0; i < 7; i++)
            {
                int rndNro = rnd.Next(40);

                if (lotto[rndNro] == 0)
                {
                    lotto[rndNro] = 1;
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < 1; i++)
            {
                int rndNro = rnd.Next(40);

                if (lotto[rndNro] == 0)
                {
                    lotto[rndNro] = 2;
                }
                else
                {
                    i--;
                }
            }

            Console.WriteLine("Loton oikea rivi on.\n");
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 1)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.Write($"\nLisänumero on ");
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 2)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine($"Tuplausnumero on {rnd.Next(40)+1}");                
        }
    }
}
