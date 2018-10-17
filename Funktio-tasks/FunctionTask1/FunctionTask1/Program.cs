using System;

namespace FunctionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functions - Task 1. \n");

            int n;
            while (true)
            {
                Console.WriteLine("Ohjelma tulostaa käyttäjän syöttämän lukumäärän verran tähtiä \n");
                Console.WriteLine("Montako tähteä haluat, että ohjelma tulostaa?: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Luku {0} ei ole sallittu luku \n", n);
                }
                else
                {
                    break;
                }

            }
            string asterisks = getNAsterisks(n);
            Console.WriteLine(asterisks);
            Console.ReadKey();
        }
        static string getNAsterisks(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += '*';
            }
            return res;
        }
    }
}
