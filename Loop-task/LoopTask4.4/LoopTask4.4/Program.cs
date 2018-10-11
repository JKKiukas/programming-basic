using System;

namespace LoopTask4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma heittää kolikkoa syöttämäsi lukumäärän verran. Lopuksi ohjelma kertoo montako kruunaa ja montako klaavaa sait. \n");
            Console.WriteLine("Montako kertaa haluat, että kolikkoa heitetään? \n");
            string userInput = Console.ReadLine();

            Random rnd = new Random();

            int heads = 0;
            int tails = 0;
            int result = 0;

            int coinFlips; int.TryParse(userInput, out coinFlips);

            for (int i = 0; i < coinFlips; i++)
            {
                result = rnd.Next(2);
                if (result == 0)
                {
                    heads++;
                }
                else if (result == 1)
                {
                    tails++;
                }
            }
            Console.WriteLine($"Kruunuja heitettiin {heads} kappale(tta) ja klaavoja heitettiin {tails} kappale(tta).");
        }
    }
}
