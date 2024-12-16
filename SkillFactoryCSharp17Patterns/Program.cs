using System;

namespace SkillFactoryCSharp17Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public string GetDayOfWeek2(int day)
        {
            switch (day)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    throw new ArgumentOutOfRangeException("Неизвестный индекс дня недели. Введите число в диапазоне 1 - 7");
            }
        }
    }


    

   
}



