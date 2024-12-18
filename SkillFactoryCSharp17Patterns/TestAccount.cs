using System;
namespace SkillFactoryCSharp17Patterns
{
    /// <summary>
    /// Так как оригинальный класс Account изменять нельзя, введём класс-наследник, чтобы расширить и протестировать функционал
    /// </summary>
    public class TestAccount : Account
    {
        public TestAccount(string type, double balance, double interest)
        {
            Type = type;
            Balance = balance;
            Interest = interest;
        }

        /// <summary>
        /// Выбор интерфейса расчёта наверное целесообразнее хранить прямо в классе-аккаунте
        /// </summary>
        /// <param name="acc"></param>
        /// <returns></returns>
        public IInterestCalculator AccountInterestCalculationInterfaceChooser()
        {
            if (this.Type == "Обычный")
            {
                return new RegularInterestCalculator();
            }
            else if (this.Type == "Зарплатный")
            {
                return new SalaryInterestCalculator();
            }
            //если тип не определён, считаем для обычного
            return new RegularInterestCalculator();
        }
    }
}

