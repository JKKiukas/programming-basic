using System;

namespace Array_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa hinnat kolmelle tuotteelle.\n");

            decimal[] productPrice = new decimal[] {7.96m, 72.0m, 99.90m};
            int[] productAmount = new int[] {1, 2, 3};
            decimal[] productTotalPrice = new decimal[3];

            for (int i = 0; i < productTotalPrice.Length; i++)
            {
                productTotalPrice[i] = productAmount[i] * productPrice[i];
                Console.WriteLine($"Tuote {i+1}. {productTotalPrice[i]:c}");
            }
        }
    }
}
