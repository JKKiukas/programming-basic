using System;

namespace String_task1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa onko käyttäjän syöte palindromi.\n");
            Console.WriteLine("Anna syöte.\n");

            string userInput = Console.ReadLine();

            if (IsPalindrome(userInput))
                Console.WriteLine($"\nAntamasi syöte {userInput} on toisin päin {userInput}, joten se on palindromi.");
            else
                Console.WriteLine($"\nAntamasi syöte {userInput} ei ole toisinpäin {userInput}, joten se ei ole palindromi.");
        }
        static bool IsPalindrome(string s)
        {
            s = s.ToUpper();
            s = s.Replace(" ", "");
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
