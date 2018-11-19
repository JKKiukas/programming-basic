using System;

namespace String_task_vowel_counter_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syötteestä vokaalien lukumäärän\n");
            string userInput = UserInput();
            string removedUserInput = VowelsRemove(userInput);
            Console.WriteLine($"\nVokaaleita syötteessä {userInput} on {removedUserInput} kappaletta.");
        }

        static string UserInput()
        {
            Console.WriteLine("Syötä sana tai lause.\n");
            return Console.ReadLine().ToUpper();
        }
        static string VowelsRemove(string s)
        {
            string vowels = "AEIOUYÄÖ";
            int vowelCounter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (s[i] == vowels[j])
                    {
                        vowelCounter++;
                        break;
                    }
                }
            }
            return vowelCounter.ToString();
        }
    }
}
