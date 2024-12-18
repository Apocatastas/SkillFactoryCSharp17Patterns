using System;
using System.Security.Principal;

namespace SkillFactoryCSharp17Patterns
{
    class Program
    {
        /// <summary>
        /// Внесла в программу тестовые данные для проверки работы выбора нужного интерфейса для расчета ставки
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var testAccountRegular = new TestAccount("Обычный", 900, 0);
            var testAccountSalary = new TestAccount("Зарплатный", 5000, 0);
            var calc = new Calculator();

            calc.CalculateInterest(testAccountRegular.AccountInterestCalculationInterfaceChooser(), testAccountRegular);
            calc.CalculateInterest(testAccountSalary.AccountInterestCalculationInterfaceChooser(), testAccountSalary);
            Console.WriteLine(testAccountRegular.Interest.ToString());
            Console.WriteLine(testAccountSalary.Interest.ToString());
            Console.ReadKey();
        }
    }
}


