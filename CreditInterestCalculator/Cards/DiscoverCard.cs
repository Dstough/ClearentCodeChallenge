using CreditInterestCalculator.BaseClasses;

namespace CreditInterestCalculator.Cards
{
    public class DiscoverCard : BaseCard
    {
        public DiscoverCard(double balance = 0d)
            :base(balance)
        {
            CardName = "Discover";
            IntrestRate = .01d;
        }
    }
}
