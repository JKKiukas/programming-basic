using System;

namespace ArrayTask3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = new int[40];
            Intro();
            RndLottoNumbers(ref lotto, 7, 1);
            RndLottoNumbers(ref lotto, 1, 2);
            PrintLotto(lotto);
        }

        static void Intro()
        {
            Console.WriteLine("Ohjelma arpoo käyttäjälle oikean lottorivin.\n");
            Console.WriteLine("Paina mitä tahansa näppäintä aloittaaksesi arvonnan.\n");
            Console.ReadKey();
        }
        static void RndLottoNumbers(ref int[] arrLotto, int amount, int value)
        {
            Random rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                int rndNumber = rnd.Next(arrLotto.Length);
                if (arrLotto[rndNumber] == 0)
                    arrLotto[rndNumber] = value;
                else
                    i--;
            }
        }

        static void PrintLotto(int[] arrLotto)
        {
            Random rnd = new Random();
            Console.Write("\nLoton oikea rivi on: ");
            for (int i = 0; i < arrLotto.Length; i++)
            {
                if (arrLotto[i] == 1)
                    Console.Write($"{i + 1} ");
            }

            Console.Write("\nLisänumero: ");
            for (int i = 0; i < arrLotto.Length; i++)
            {
                if (arrLotto[i] == 2)
                    Console.WriteLine($"{i + 1} ");
            }

            Console.WriteLine($"\nPlussausnumero: {rnd.Next(40) + 1}");
        }
    }
}