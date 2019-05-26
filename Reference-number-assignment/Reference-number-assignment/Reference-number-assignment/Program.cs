using System;
using System.IO;

namespace Reference_number_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\TEMP\viitenumero.txt";
            int[] factor = new int[] { 7, 3, 1 };
            ConsoleKeyInfo cki;

            do
            {
                cki = UserInterface();
                Console.WriteLine();
                switch (cki.Key)
                {
                    case ConsoleKey.F1:
                        if (RefNumberChecker(UserInput("Syötä viitenumero: ", 4), factor))
                        {
                            Console.WriteLine("Viitenumero on oikein.");
                        }

                        else
                        {
                            Console.WriteLine("Viitenumero on väärä.");
                        }
                        break;

                    case ConsoleKey.F2:
                        Console.WriteLine($"Viitenumero kokonaisuudessaan: {RefNumberCreator(UserInput("Syötä viitenumeron alkuosa: ", 3), factor)}");
                        break;

                    case ConsoleKey.F3:
                        OptionF3(factor, path);
                        break;

                    case ConsoleKey.F4:
                        ReadFile(path);
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("\nOhjelma suljetaan.");
                        break;

                    default:
                        Console.WriteLine("Väärä valinta.");
                        break;
                }
                Console.WriteLine("\nPaina mitä vain jatkaaksesi.");
                Console.ReadKey();
                Console.Clear();

            } while (cki.Key != ConsoleKey.Escape);

        }
        static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("[F1] Tarkasta viitenumero.");
            Console.WriteLine("[F2] Luo yksi viitenumero.");
            Console.WriteLine("[F3] Luo viitenumeroita haluttu määrä ja tallenna ne viitenumero tiedostoon.");
            Console.WriteLine("[F4] Lue viimeksi luodut viitenumerot viitenumerotiedostosta tiedostosta.");
            Console.WriteLine("[Esc] Sulje ohjelma.");
            Console.Write("\nSyötä valinta: ");

            return Console.ReadKey();
        }

        static string UserInput(string askInput, int length)
        {
            while (true)
            {
                Console.Write(askInput);
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out int number);

                if (isNumber && number > 0)
                {

                    if (input.Length >= length)
                    {
                        return input;
                    }

                    else
                    {
                        Console.WriteLine("Viitenumeron pitää olla vähintään 4 numeroinen (3 + tarkiste).");
                    }
                }
                else
                {
                    Console.WriteLine("Syötteessä oli virhe! Syöte saa sisältää vain numeroita.");
                }
            }
        }

        static bool RefNumberChecker(string number, int[] fact)
        {
            int sum = 0;
            int j = number.Length - 2;

            for (int i = 0; i < number.Length - 1; i++)
            {
                int nr = Convert.ToInt32(number[j].ToString());
                sum += nr * fact[i % 3];
                j--;
            }

            int checkNumber = 10 - (sum % 10);

            if (checkNumber == 10)
            {
                checkNumber = 0;
            }

            if (checkNumber == Convert.ToInt32(number[number.Length - 1].ToString()))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static string RefNumberCreator(string number, int[] fact)
        {
            int sum = 0;
            int j = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                int nr = Convert.ToInt32(number[j].ToString());
                sum += nr * fact[i % 3];
                j--;
            }

            int checkNumber = 10 - (sum % 10);

            if (checkNumber == 10)
            {
                checkNumber = 0;
            }
            number += checkNumber;
            number = StringSplitter(number);
            return number;
        }

        static string[] BaseRefNumberGenerator()
        {
            string baseNumber = UserInput("Syötä viitenumeron alkuosa: ", 3);
            int count = int.Parse(UserInput("Syötä viitenumeroiden määrä: ", 1));
            string[] refNumbers = new string[count];
            int j;

            for (int i = 0; i < refNumbers.Length; i++)
            {
                j = i + 1;
                refNumbers[i] = baseNumber + j;
            }
            return refNumbers;
        }

        static string[] RefNumberGenerator(string[] numbers, int[] fact)
        {
            string number;

            for (int i = 0; i < numbers.Length; i++)
            {
                number = numbers[i];
                numbers[i] = RefNumberCreator(number, fact);
            }
            return numbers;
        }

        static string StringSplitter(string str)
        {
            int j = str.Length - 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (i % 5 == 0 && j > 0)
                {
                    str = str.Insert(j, " ");
                }
                j--;
            }
            return str;
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

        static void ReadFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    Console.WriteLine("\nAikaisemmin luodut viitenumerot: ");
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tapahtui virhe: { ex.Message}");
            }
        }

        static string[] RandomRefNumberGenerator(int[] fact)
        {
            Random rnd = new Random();
            int count = int.Parse(UserInput("Syötä viitenumeroiden määrä: ", 1));
            string[] refNumbers = new string[count];
            string number = "";
            int random;

            for (int i = 0; i < refNumbers.Length; i++)
            {
                random = rnd.Next(3, 20);
                number = "";
                for (int j = 0; j < random; j++)
                {
                    number += rnd.Next(1, 9);
                }
                refNumbers[i] = number;
            }
            refNumbers = RefNumberGenerator(refNumbers, fact);

            return refNumbers;
        }

        static ConsoleKeyInfo InterfaceTwo()
        {
            Console.WriteLine("Valitse luodaanko viitenumerot samalla alkuosalla vai kokonaan satunnaisena.");
            Console.WriteLine("[F1] Syötä viitenumeron alkuosa.");
            Console.WriteLine("[F2] Luo kokonaan satunnaiset viitenumerot.");
            Console.Write("\nSyötä valinta: ");

            return Console.ReadKey();
        }

        static void RefNumberPrinter(string[] numbers)
        {
            Console.WriteLine("\nOhjelma loi alla olevat viitenumerot:\n");

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
                    string[] nr = RefNumberGenerator(BaseRefNumberGenerator(), factor);
                    RefNumberPrinter(nr);
                    WriteToFile(nr, path);
                    break;

                case ConsoleKey.F2:
                    string[] no = RandomRefNumberGenerator(factor);
                    RefNumberPrinter(no);
                    WriteToFile(no, path);
                    break;

                default:
                    Console.WriteLine("Väärä valinta.");
                    break;
            }
        }
    }
}