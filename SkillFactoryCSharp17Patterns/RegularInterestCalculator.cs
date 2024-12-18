using System;
namespace SkillFactoryCSharp17Patterns
{
    public class RegularInterestCalculator : IInterestCalculator
    {
        public void Calculate(Account account)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;
            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;
            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}

