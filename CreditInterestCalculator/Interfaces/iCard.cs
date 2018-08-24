using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInterestCalculator.Interfaces
{
    public interface ICard
    {
        string CardName { get; }
        double Balance { get; set; }
        double IntrestRate { get; }

        double GetInterestAmmount();
    }
}
