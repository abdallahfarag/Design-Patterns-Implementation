using FactoryMethodDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Factory
{
    public class PlatinumFactory : ICardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public ICreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
