using CreditInterestCalculator.BaseClasses;

namespace CreditInterestCalculator.Cards
{
    public class VisaCard : BaseCard
    {
        public VisaCard(double balance = 0d)
            :base(balance)
        {
            CardName = "Visa";
            IntrestRate = .1d;
        }
    }
}
