using System;

namespace ArrayTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            int[] arrT_1 = RndArray(10);
            int[] arrT_2 = RndArray(10);
            int[] arrT_3 = CompareArray(arrT_1, arrT_2 );
            PrintData(arrT_1, "arrT_1: ");
            PrintData(arrT_2, "arrT_2: ");
            PrintData(arrT_3, "arrT_3: ");

        }
        static void Intro()
        {
            Console.WriteLine("        01 02 03 04 05 06 07 08 09 10");
            Console.WriteLine("        -----------------------------");

        }
        static int[] RndArray(int lenght)
        {
            Random rnd = new Random();
            int[] arrT = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arrT[i] = rnd.Next(20);
            }
            return arrT;
        }
        static void PrintData(int[] arrX, string label)
        {
            int[] arrT_1 = new int[10];
            Console.Write(label);
            for (int i = 0; i < arrX.Length; i++)
            {
                Console.Write($"{arrX[i]:d2} ");
            }
            Console.WriteLine();
        }
        static int [] CompareArray(int [] arr1, int [] arr2)
        {
            int[] arrC = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    arrC[i] = arr1[i];
                }
                else
                    arrC[i] = arr2[i];
            }
            return arrC;
        }
        
    }
}
