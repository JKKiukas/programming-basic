using System;

namespace String_task_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syötteestä l kirjainten lukumäärän.\n");
            Console.WriteLine("Anna syöte.\n");

            string text = Console.ReadLine().ToLower();
            int cntrL = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == 'l')
                    cntrL++;
            }
            Console.WriteLine($"\nSyötteessä {text} on {cntrL} L kirjainta.");
        }
    }
}
