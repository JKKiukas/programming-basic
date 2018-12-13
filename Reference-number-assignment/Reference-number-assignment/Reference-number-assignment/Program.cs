using System;
using System.IO;

namespace Reference_number_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] f = new int[] { 7, 3, 1 };
            string path = @"C:\TEMP\referencenumber.txt";
            ConsoleKeyInfo cki;

            do
            {
                cki = UserInterface();
                Console.WriteLine();
                switch (cki.Key)
                {
                    case ConsoleKey.F1:
                        if (CheckReferenceNumber(UserInput("Syötä viitenumero: ", 4), f))
                        {
                            Console.WriteLine("Viitenumero on oikein.");
                        }
                        else
                        {
                            Console.WriteLine("Viitenumero on väärin.");
                        }
                        break;

                    case ConsoleKey.F2:
                        Console.WriteLine($"Viitenumero on kokonaisuudessaan: {CreateReferenceNumber(UserInput("Syötä viitenumeron alkuosa: ", 3), f)}");
                        break;

                    case ConsoleKey.F3:
                        OptionF3(f, path);
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Ohjelma suljetaan.");
                        break;

                    default:
                        Console.WriteLine("Väärä syöte. Valitse F1, F2, F3 tai Esc.");
                        break;
                }
                Console.WriteLine("Paina enter-näppäintä jatkaaksesi.");
                Console.ReadLine();
                Console.Clear();
            } while (cki.Key != ConsoleKey.Escape);

        }
        static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("Käyttäjä voi pyytää ohjelmaa tekemään seuraavat neljä asiaa.");
            Console.WriteLine("Paina näppäintä mitä haluat tehdä.\n");

            Console.WriteLine("[F1] Ohjelma tarkistaa kotimaisen viitenumeron.");
            Console.WriteLine("[F2] Ohjelma luo kotimaisen viitenumeron.");
            Console.WriteLine("[F3] Ohjelma luo käyttäjän syöttämän määrän kotimaisia viitenumeroita ja tallentaa ne tiedostoon.");
            Console.WriteLine("[Esc] Sulkee ohjelman.");

            return Console.ReadKey();
        }
        static string UserInput(string askInput, int length)
        {
            while (true)
            {
                Console.Write(askInput);
                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out int number);
                if (isNumber && number > 0)
                {
                    if (userInput.Length >= length)
                    {
                        return userInput;
                    }
                    else
                    {
                        Console.WriteLine("Viitenumeron pitää sisältää vähintään 4 numeroa (3 + tarkiste).");
                    }
                }
                else
                {
                    Console.WriteLine("Syötteessä on virhe! Syötessä saa olla vain numeroita.");
                }
            }
        }
        static bool CheckReferenceNumber(string number, int[] f)
        {
            int sum = 0;
            int j = number.Length - 2;

            for (int i = 0; i < number.Length - 1; i++)
            {
                int nr = Convert.ToInt32(number[j].ToString());
                sum += nr * f[i % 3];
                j--;
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }
            if (checkNum == Convert.ToInt32(number[number.Length - 1].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string CreateReferenceNumber(string number, int[] f)
        {
            int sum = 0;
            int j = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                int nr = Convert.ToInt32(number[j].ToString());
                sum += nr * f[i % 3];
                j--;
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }
            number += checkNum;
            number = SplitString(number);
            return number;
        }
        static string[] GenerateBaseReferenceNumber()
        {
            string baseNum = UserInput("Syötä viitenumeron alkuosa: ", 3);
            int count = int.Parse(UserInput("Syötä viitenumeroiden määrä: ", 1));
            string[] referenceNumbers = new string[count];
            int j;

            for (int i = 0; i < referenceNumbers.Length; i++)
            {
                j = i + 1;
                referenceNumbers[i] = baseNum + j;
            }
            return referenceNumbers;
        }
        static string[] ReferenceNumberGenerator(string[] numbers, int[] f)
        {
            string number;
            for (int i = 0; i < numbers.Length; i++)
            {
                number = numbers[i];
                numbers[i] = CreateReferenceNumber(number, f);
            }
            return numbers;
        }
        static string SplitString(string s)
        {
            int j = s.Length - 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (i % 5 == 0 && j > 0)
                {
                    s = s.Insert(j, " ");
                }
                j--;
            }
            return s;
        }
        static void WriteToFile(string[] numbers, string path)
        {
            StreamWriter R = new StreamWriter(path);

            for (int i = 0; i < numbers.Length; i++)
            {
                R.WriteLine(numbers[i]);
            }
            R.Close();
        }
        static string[] GenerateRandomReferenceNumber(int[] f)
        {
            Random rnd = new Random();
            int count = int.Parse(UserInput("Syötä haluamasi viitenumeroiden määrä: ", 1));
            string[] referenceNumbers = new string[count];
            string number = "";
            int random;
            for (int i = 0; i < referenceNumbers.Length; i++)
            {
                random = rnd.Next(3, 20);
                number = "";
                for (int j = 0; j < random; j++)
                {
                    number += rnd.Next(1, 9);
                }
                referenceNumbers[i] = number;
            }
            referenceNumbers = ReferenceNumberGenerator(referenceNumbers, f);

            return referenceNumbers;
        }
        static ConsoleKeyInfo InterfaceTwo()
        {
            Console.WriteLine("Paina F1-näppäintä, jotta ohjelma tekee satunnaisia viitenumeroita.");

            return Console.ReadKey();
        }

        static void PrintReferenceNumber(string[] numbers)
        {
            Console.WriteLine("Ohjelma teki seuraavat viitenumerot:\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void OptionF3(int[] factor, string path)
        {
            Console.Clear();
            ConsoleKeyInfo cki = InterfaceTwo();
            Console.WriteLine();
            switch (cki.Key)
            {
                case ConsoleKey.F1:
                    string[] no = GenerateRandomReferenceNumber(factor);
                    PrintReferenceNumber(no);
                    WriteToFile(no, path);
                    break;

                default:
                    Console.WriteLine("Väärä valinta. Sinun on painettava F1-näppäintä.");
                    break;
            }
        }
        private static object BaseRefNumberGenerator()
        {
            throw new NotImplementedException();
        }

        private static string[] RefNumberGenerator(object p, int[] factor)
        {
            throw new NotImplementedException();
        }
    }
}