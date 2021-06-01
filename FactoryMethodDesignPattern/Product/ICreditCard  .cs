using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Product
{
    public interface ICreditCard
    {
        string CardType { get;}
        int CreditLimit { get; set; }
        int AnnualCharge { get; set; }
    }
}
