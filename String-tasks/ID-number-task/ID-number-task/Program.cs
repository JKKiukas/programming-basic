using System;

namespace ID_number_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            string userInput = Console.ReadLine();
            int testOutput = Tester(userInput);
            EndMarkGenerator(testOutput, userInput);
        }
        static void Intro()
        {
            Console.WriteLine("Ohjelma tarkistaa onko henkikötunnus oikein ja kertoo tarkistusmerkin.\n");
            Console.WriteLine("Syötä henkilötunnus ilman tarkistusmerkkiä.\n");
        }
        static int Tester(string id)
        {
            int day = int.Parse(id.Substring(0, 2));
            int month = int.Parse(id.Substring(2, 2));
            int year = int.Parse(id.Substring(4, 2));

            string century = "+-A";
            int centuryNum = 1800;
            int j = 0;

            for (int i = 0; i == century.Length; i++)
            {
                if (id.Contains(century[i]))
                {
                    year += centuryNum + j * i;
                    i = century.Length;
                }
                j += 100;
            }
            int correct = 1;
            try
            {
                DateTime d = new DateTime(year, month, day);
            }
            catch (Exception)
            {
                Console.WriteLine("Päivämäärä tai kuukausi on väärin.");
                correct = 0;
            }
            return correct;
        }
        static void EndMarkGenerator(int validity, string id)
        {
            string endMarkList = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            if (validity == 1)
            {
                id = id.Remove(6, 1);
                int idNumber = int.Parse(id);
                int endMarkNum = idNumber % 31;
                Console.WriteLine($"\nHenkilötunnus on oikein ja tarkistusmerkkisi on {endMarkList[endMarkNum]}");
            }
        }
    }
}