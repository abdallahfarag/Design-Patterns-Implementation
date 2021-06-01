using FactoryMethodDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Factory
{
    public class MoneyBackFactory : ICardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public ICreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }
    }
}
