using System;
using System.Text.RegularExpressions;

namespace ID_number_task_version2
{
    class Program
    {
        static void Main(string[] args)
        {
            string idNr;
            char userChoice;
            do
            {
                userChoice = UserInterface();
                Console.WriteLine();
                switch (userChoice)
                {
                    case 'T':
                        {
                            idNr = UserInput();
                            if (IdDateChecker(idNr))
                            {
                                Console.WriteLine(IdNumberChecker(idNr, CalculateLastChar(idNr)));
                                Console.WriteLine($"Henkilö on {IdGenderChecker(idNr)}.");
                            }
                            else
                            {
                                Console.WriteLine("Päivämäärä tai kuukausi ei ole mahdollinen.");
                            }
                            break;
                        }
                    case 'U':
                        {
                            idNr = UserInput();
                            if (IdDateChecker(idNr))
                            {
                                Console.WriteLine($"Henkilötunnuksen tarkiste merkki on: {CalculateLastChar(idNr)}");
                                Console.WriteLine($"Henkilötunnus kokonaisuudessaan: {idNr}{CalculateLastChar(idNr)}");
                                Console.WriteLine($"Henkilö on {IdGenderChecker(idNr)}.");
                            }
                            else
                            {
                                Console.WriteLine("Päivämäärä tai kuukausi ei ole mahdollinen.");
                            }
                            break;
                        }
                    case 'X':
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Väärä valinta.");
                            break;
                        }
                }
                Console.WriteLine("Press anykey.");
                Console.ReadKey();
                Console.Clear();
            } while (userChoice != 'X');
        }

        static char UserInterface()
        {
            Console.WriteLine("Valitse mitä haluat ohjelman tekevän.\n");
            Console.WriteLine("[T] Tarkista henkikötunnuksen oikeellisuus.");
            Console.WriteLine("[U] Luo uusi henkilötunnus.");
            Console.WriteLine("[X] Sulje ohjelma.");

            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static string UserInput()
        {

            Console.Write("Syötä henkikötunnus tai sen alkuosa muodossa (PPKKVV-XXX[Q]): ");
            string id = Console.ReadLine().ToUpper();
            while (true)
            {
                if (new Regex("\\d{6}[-+A]\\d{3}[0-9A-Y]?").IsMatch(id))
                {
                    return id;
                }
                else
                {
                    Console.WriteLine("Henkilötunnus ei ole oikeassa muodossa!");
                    Console.Write("Syötä uusi henkilötunnus tai sen alkuosa (PPKKVV-XXX[Q]): ");
                    id = Console.ReadLine().ToUpper();
                }
            }
        }

        static bool IdDateChecker(string id)
        {
            int day = int.Parse(id.Substring(0, 2));
            int month = int.Parse(id.Substring(2, 2));
            int year = int.Parse(id.Substring(4, 2));
            bool correct = true;
            string centuryChar = "+-A";
            int j = 0;
            int centuryInt = 1800;
            for (int i = 0; i < centuryChar.Length; i++)
            {
                if (id[7] == centuryChar[i])
                {
                    year += centuryInt + i * j;
                }
                j += 100;
            }
            try
            {
                DateTime d = new DateTime(year, month, day);
            }
            catch
            {
                correct = false;
            }
            return correct;
        }

        static char CalculateLastChar(string id)
        {
            string lastChars = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int luku = int.Parse(id.Substring(0, 6) + id.Substring(7, 3));
            return lastChars[luku % 31];
        }

        static string IdNumberChecker(string id, char lastChar)
        {
            if (id.Length == 11)
            {
                if (id[10] == lastChar)
                {
                    return "Henkilötunnus on oikea.";
                }
                else
                {
                    return "Henkikötunnus on väärä.";
                }
            }
            else
            {
                return $"Et syöttänyt koko henkikötunnusta.\n" +
                        $"Henkilötunnus on kokonaisuudessaan: {id}{lastChar}";
            }
        }

        static string IdGenderChecker(string id)
        {
            int genderNr = id[9];

            if (genderNr % 2 == 0)
            {
                return "nainen";
            }
            else
            {
                return "mies";
            }
        }
    }
}
