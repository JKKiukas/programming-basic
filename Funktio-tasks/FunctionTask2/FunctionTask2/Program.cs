using System;

namespace FunctionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro(out int x, out int y);
            PrintData(SmallerNumber(x,y));
        }

        static void Intro(out int number1, out int number2)
        {
            Console.WriteLine("Ohjelma pyytää käyttäjää syöttämään kaksi lukua. Ohjelma kertoo kumpi luvuista on pienempi. \n");
            Console.Write("Syötä 1. luku: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä 2. luku: ");
            number2 = int.Parse(Console.ReadLine());
        }

        static string SmallerNumber(int a, int b)
        {
            if (a == b)
                return $"Luku {a} on yhtäsuuri kuin luku {b}";
            else if (a < b)
                return $"Luku {a} on pienempi kuin luku {b}";
            else
                return $"Luku {b} on pienempi kuin luku {a}";
        }
        static void PrintData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
