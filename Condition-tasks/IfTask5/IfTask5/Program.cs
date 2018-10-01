using System;

namespace IfTask5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma selvittää maatalousnäyttelyn lipunhinnan. \n");
            Console.WriteLine("Kirjoita mihin alla olevaa ryhmään kuulut. \n");
            Console.WriteLine("Oletko varusmies? ");
            Console.WriteLine("Oletko opiskelija? ");
            Console.WriteLine("Oletko Mtk:n jäsen? ");
            Console.WriteLine("Oletko opiskelija sekä Mtk:n jäsen?  \n");
            Console.WriteLine("Jos et kuulu mihinkään yllä mainittuun ryhmään, syötä ikäsi. \n");

            string userInput = Console.ReadLine();

            int ticketPrice = 16;
            double discount = 0.15;
            double discount1 = 0.5;
            double discount2 = 0.45;
            double discount3 = 0.6;
            int discount4 = 0;
            int age;

            double Mtk = discount;
            double varusmies = discount1;
            double opiskelija = discount2;
            double opiskelija1 = discount3;
            int eiAlennusta = discount4;

            if (userInput.ToLower() == ("mtk"))
                Console.WriteLine($"Lipun hintasi on {(1 - discount) * ticketPrice:C}. Tervetuloa");
            else if (userInput.ToLower() == ("varusmies"))
                Console.WriteLine($"Lipun hintasi on {(1 - discount1) * ticketPrice:C}. Tervetuloa.");
            else if (userInput.ToLower() == ("opiskelija"))
                Console.WriteLine($"Lipun hintasi on {(1 - discount2) * ticketPrice:C}. Tervetuloa.");
            else if (userInput.ToLower().Contains("opiskelija") && userInput.ToLower().Contains("mtk"))
                Console.WriteLine($"Lipun hintasi on {(1 - discount3) * ticketPrice:C}. Tervetuloa.");
            else if (Int32.TryParse(userInput, out age) && age < 7)
                Console.WriteLine("Lippu on sinulle ilmainen. Tervetuloa.");
            else if (Int32.TryParse(userInput, out age) && age > 6 && age < 16 || age > 64)
                Console.WriteLine($"Lipun hintasi on {(1 - discount1) * ticketPrice:C}");
            else
                Console.WriteLine($"Lipun hintasi on {ticketPrice:C}. Tervetuloa.");

        }
    }
}
