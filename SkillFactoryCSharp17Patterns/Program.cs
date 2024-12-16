using System;

namespace SkillFactoryCSharp17Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Average(1);
            Average(2);
            Average(3);
            Console.ReadKey();
        }

        /// <summary>
        /// Prints average temperature
        /// </summary>
        /// <param name="period">1 for daily, 2 for weekly, 3 for monthly</param>
        private static void Average(byte period)
        {
            string periodStr = String.Empty;
            string celsium = String.Empty;
            switch (period)
            {
                case 2:
                    periodStr = "weekly";
                    celsium = (new Random().Next(10, 35)).ToString();
                    break;
                case 3:
                    periodStr = "monthly";
                    celsium = (new Random().Next(10, 40)).ToString();
                    break;
                default:
                    periodStr = "daily";
                    celsium = (new Random().Next(10, 30)).ToString();
                    break;


            }
            Console.WriteLine("Welcome to the {0} forecast page", periodStr);
            Console.WriteLine("The average temperature expects to be around {0} C\n", celsium);

        }

    }
}



