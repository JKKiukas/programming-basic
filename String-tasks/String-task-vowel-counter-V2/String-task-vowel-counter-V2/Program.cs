using System;

namespace String_task_vowel_counter_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syötteestä vokaalien lukumäärän.\n");
            string userInput = UserInput();
            string removedUserInput = VowelsRemove(userInput);
            Console.WriteLine($"\nVokaaleita syötteessä {userInput} on {userInput.Length - removedUserInput.Length} kappaletta.");
        }

        static string UserInput()
        {
            Console.WriteLine("Syötä sana tai lause.\n");
            return Console.ReadLine().ToUpper();
        }

        static string VowelsRemove(string s)
        {
            string vowels = "AEIOUYÄÖ";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (s[i] == vowels[j])
                    {
                        s = s.Remove(i, 1);
                        i--;
                        break;
                    }
                }
            }
            return s;
        }
    }
}
