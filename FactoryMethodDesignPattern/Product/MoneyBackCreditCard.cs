using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Product
{
    public class MoneyBackCreditCard : ICreditCard
    {
        readonly string _cardType;
        int _creditLimit;
        int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public string CardType { get { return _cardType; } }

        public int CreditLimit { get { return _creditLimit; } set { _creditLimit = value; } }
        public int AnnualCharge { get { return _annualCharge; } set { _annualCharge = value; } }
    }
}
