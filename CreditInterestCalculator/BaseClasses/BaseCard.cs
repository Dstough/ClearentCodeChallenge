using CreditInterestCalculator.Interfaces;

namespace CreditInterestCalculator.BaseClasses
{
    public abstract class BaseCard : ICard
    {
        protected BaseCard(double balance = 0d)
        {
            CardName = "Default";
            Balance = balance;
            IntrestRate = 0d;
        }
        public string CardName { get; protected set; }
        public double Balance { get; set; }
        public double IntrestRate { get; protected set; }
        public double GetInterestAmmount()
        {
            return Balance * IntrestRate;
        }
    }
}
