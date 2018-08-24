using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditInterestCalculator;
using CreditInterestCalculator.BaseClasses;
using CreditInterestCalculator.Cards;

namespace InterestTest
{
    [TestClass]
    public class TestCases
    {
        [TestMethod]
        public void Case1()
        {
            var person = new Person("Alice",
                new List<Wallet>
                {
                    new Wallet(new List<BaseCard>()
                    {
                        new VisaCard(100.00d),
                        new MasterCard(100.00d),
                        new DiscoverCard(100.00d)
                    })
                }
            );
            Console.WriteLine(DisplayPersonsInterestAmmount(person));
        }

        [TestMethod]
        public void Case2()
        {
            var person = new Person("Bob",new List<Wallet>()
            {
                new Wallet(new List<BaseCard>()
                {
                    new VisaCard(100.00d),
                    new MasterCard(100.00d)
                }),
                new Wallet(new List<BaseCard>()
                {
                    new MasterCard(100.00d)
                }),
            });
            Console.WriteLine(DisplayPersonsInterestAmmount(person));
        }

        [TestMethod]
        public void Case3()
        {
            var person1 = new Person("Chris", new List<Wallet>()
            {
                new Wallet(new List<BaseCard>()
                { 
                    new VisaCard(100.00d),
                    new MasterCard(100.00d)
                })
            });
            var person2 = new Person("Dom", new List<Wallet>()
            {
                new Wallet(new List<BaseCard>()
                {
                    new VisaCard(100.00d),
                    new MasterCard(100.00d)
                })
            });
            Console.WriteLine( DisplayPersonsInterestAmmount(person1)+
                   DisplayPersonsInterestAmmount(person2));
        }

        public string DisplayPersonsInterestAmmount(Person person)
        {
            var display = $"The total interest for {person.Name} is: {person.GetInterestAmmount():C} \n";
            for (var walletCount = 0; walletCount < person.Wallets.Count; walletCount++)
            {
                display += $"   Wallet {walletCount+1}: {person.Wallets[walletCount].GetInterestAmmount():C} \n";
                for (var cardCount = 0; cardCount < person.Wallets[walletCount].Cards.Count; cardCount++)
                {
                    display += $"       Card {cardCount+1}: {person.Wallets[walletCount].Cards[cardCount].GetInterestAmmount():C} \n";
                }
            }
            return display + "\n";
        }
    }
}
