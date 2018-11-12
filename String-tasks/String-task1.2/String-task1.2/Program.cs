using System;

namespace String_task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa käyttäjän syötteestä e kirjaimen @ merkiksi.\n");
            Console.WriteLine("Anna syöte.\n");

            string text = Console.ReadLine();
            Console.WriteLine(text.Replace("e", "@"));
        }
    }
}
