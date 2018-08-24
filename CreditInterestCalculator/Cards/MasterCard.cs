using CreditInterestCalculator.BaseClasses;

namespace CreditInterestCalculator.Cards
{
    public class MasterCard : BaseCard
    {
        public MasterCard(double balance = 0d) 
            :base(balance)
        {
            CardName = "Master Card";
            IntrestRate = .05d;
        }
    }
}
