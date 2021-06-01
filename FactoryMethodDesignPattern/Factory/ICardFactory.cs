using FactoryMethodDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Factory
{
    public interface ICardFactory
    {
        ICreditCard GetCreditCard();
    }
}
