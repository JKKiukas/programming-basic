using System;

namespace Recap_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 2, 5, 10, 7, ja 3 tähteä omille riveilleen.\n");
            int[] numbers = new int[] { 2, 5, 10, 7, 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(GetStars(numbers[i]));
                //PrintStars(numbers[i]);
            }
        }

        /// <summary>
        /// Prints stars
        /// length = the amount of stars
        /// </summary>
        /// <param name="length"></param>
        static void PrintStars(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// returns the amount of stars
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        static string GetStars(int length)
        {
            string returnStars = "";
            for (int i = 0; i < length; i++)
            {
                /*returnStars += "*";*/
                returnStars = $"{returnStars}*";
            }
            return returnStars;
        }
    }
}
