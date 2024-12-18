using System;
namespace SkillFactoryCSharp17Patterns
{
    public class Calculator
    {
        public void CalculateInterest(IInterestCalculator interestCalculator, Account account)
        {
            interestCalculator.Calculate(account);
        }
    }
}

