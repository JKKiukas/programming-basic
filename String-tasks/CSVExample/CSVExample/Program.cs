using System;

namespace CSVExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma käsittelee pilkuilla erotetun datan.\n");
            string data = "aasi,kahvi,väsymys,kaneli,aivot,tietokone,pettymys,torstai,pora,koodi,tietokone,18.";
            //Versio1(data);
            //Versio2(data);
            string[] tmpData = Versio3(data);
            PrintData(tmpData);

        }

        #region Versio 1
        /// <summary>
        /// Function replaces strings commas with new lines
        /// d = strings data, which is separated with commas
        /// </summary>
        /// <param name="d"></param>
        static void Versio1(string d)
        {

            string tmpData = d.Replace(',', '\n');

            Console.WriteLine(d);
            Console.WriteLine(tmpData);
        }
        #endregion

        #region Versio 2
        /// <summary>
        /// Function searches for commas and prints data in between with commas
        /// </summary>
        /// <param name="d"></param>
        static void Versio2(string d)
        {
            int i = 0;
            while (true)
            {
                int p = d.IndexOf(',', i);

                if (p != -1)
                {
                    Console.WriteLine(d.Substring(i, p - i));
                    i = p + 1;
                }
                else
                {
                    Console.WriteLine(d.Substring(i));
                    break;
                }
            }
        }
        #endregion

        #region Versio 3
        /// <summary>
        /// Function splits data using method
        /// </summary>
        /// <param name="d"></param>
        static string[] Versio3(string d)
        {
            string[] tmpData = d.Split(',');
            return tmpData;
        }

        #endregion
        static void PrintData(string[] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i].ToUpper());
            }
        }
    }
}