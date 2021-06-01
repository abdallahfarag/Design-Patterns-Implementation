using FactoryMethodDesignPattern.Factory;
using FactoryMethodDesignPattern.Product;
using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICardFactory cardFactory=null;
            Console.WriteLine("Enter card type (moneyback, titanium, platinum): ");
            string cardType = Console.ReadLine();
            switch (cardType)
            {
                case "moneyback":
                    cardFactory = new MoneyBackFactory(1000, 2000);
                    break;
                case "titanium":
                    cardFactory = new TitaniumFactory(3000, 4000);
                    break;
                case "platinum":
                    cardFactory = new PlatinumFactory(5000, 6000);
                    break;
                default:
                    Console.WriteLine("This type not available!!");
                    break;
            }

           if(cardFactory.GetCreditCard() != null)
            {
                ICreditCard creditCard = cardFactory.GetCreditCard();
                Console.WriteLine("Selected card details are below : ");
                Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                    creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            }

            
        }
    }
}
