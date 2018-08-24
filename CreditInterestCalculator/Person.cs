using System.Collections.Generic;
using System.Linq;

namespace CreditInterestCalculator
{
    public class Person
    {
        public List<Wallet> Wallets { get; set; }
        public string Name { get; }
        public Person(string name = "", List<Wallet> wallets = null)
        {
            Wallets = wallets ?? new List<Wallet>();
            Name = name;
        }
        public double GetInterestAmmount()
        {
            return Wallets.Sum(e => e.GetInterestAmmount());
        }
    }
}
