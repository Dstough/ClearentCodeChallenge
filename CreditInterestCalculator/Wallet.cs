using System.Collections.Generic;
using System.Linq;
using CreditInterestCalculator.BaseClasses;

namespace CreditInterestCalculator
{
    public class Wallet
    {
        public List<BaseCard> Cards { get; set; }
        public Wallet(List<BaseCard> cards = null)
        {
            Cards = cards ?? new List<BaseCard>();
        }
        public double GetInterestAmmount()
        {
            return Cards.Sum(e => e.GetInterestAmmount());
        }
    }
}
