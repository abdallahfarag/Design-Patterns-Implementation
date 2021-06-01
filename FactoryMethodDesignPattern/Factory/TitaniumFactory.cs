using FactoryMethodDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Factory
{
    public class TitaniumFactory : ICardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public ICreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
