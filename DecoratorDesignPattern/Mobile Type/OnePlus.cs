using DecoratorDesignPattern.Android_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Mobile_Type
{
    public class OnePlus : IAndroid
    {
        IAndroid _android;
        public OnePlus(IAndroid android)
        {
            _android = android;
        }
        public string GetAndroidOS()
        {
            return _android.GetAndroidOS()+ "Android 11.0 OS";
        }

        public string GetModel()
        {
            return _android.GetModel()+ "OnePlus 202";
        }

        public double GetPrice()
        {
            return _android.GetPrice()+ 4000.0;
        }
    }
}
