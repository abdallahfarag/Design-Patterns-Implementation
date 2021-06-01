using DecoratorDesignPattern.Android_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Mobile_Type
{
    public class Android : IAndroid
    {

        public string GetAndroidOS()
        {
            return "Android OS is : ";
        }

        public string GetModel()
        {
            return "Mobile Model is ";
        }

        public double GetPrice()
        {
            return 10000.0;
        }
    }
}
