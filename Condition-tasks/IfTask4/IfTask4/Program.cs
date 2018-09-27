using System;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee 3 numero nousevaan järjestykseen");
            Console.WriteLine("Syötä 3 numeroa: ");
            string userInput = Console.ReadLine();
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();

            int X = 0;
            int Y = 0;
            int Z = 0;
            bool isNumber = int.TryParse(userInput, out X);
            bool isNumber1 = int.TryParse(userInput1, out Y);
            bool isNumber2 = int.TryParse(userInput2, out Z);

            if (isNumber && isNumber1 && isNumber2)
                Console.WriteLine("Kaikki syötteet olivat numeroita");
            else
                Console.WriteLine("Väärä syöte");

            if (X < Y)
            {
                if (Y < Z)
                {
                    Console.WriteLine($"{X} {Y} {Z}");
                }
                else if (Z > X)
                {
                    Console.WriteLine($"{X} {Z} {Y} ");
                }
                else
                {
                    Console.WriteLine($"{Z} {X} {Y} ");
                }
            }
            else
            {
                if(X < Z)
                {
                    Console.WriteLine($"{Y} {X} {Z}");
                }
                else if(Y < Z)
                {
                    Console.WriteLine($"{Y} {Z} {X}");
                }
                else
                {
                    Console.WriteLine($"{Z} {Y} {X}");
                }
            }
        }
    }
}
