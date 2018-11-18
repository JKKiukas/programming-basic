using System;

namespace String_task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma ilmoittaa käyttäjän syötteestä merkkien lukumäärän.\n");
            Console.WriteLine("Anna syöte.\n");

            string text = Console.ReadLine();
            Console.WriteLine($"\nSyötteessä on {text.Length} merkkiä.");
        }
    }
}
