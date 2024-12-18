using System;
namespace SkillFactoryCSharp17Patterns
{
    public class SalaryInterestCalculator : IInterestCalculator
    {
        public void Calculate(Account account)
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}

