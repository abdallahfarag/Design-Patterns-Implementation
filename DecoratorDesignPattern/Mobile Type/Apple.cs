using DecoratorDesignPattern.Mobile_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Mobile_Type
{
    public class Apple : IMobile
    {
        public string GetModel()
        {
            return "IPhone 12";
        }

        public double GetPrice()
        {
            return 20000;
        }
    }
}
