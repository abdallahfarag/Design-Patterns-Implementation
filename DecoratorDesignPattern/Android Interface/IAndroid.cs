using DecoratorDesignPattern.Mobile_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Android_Interface
{
    public interface IAndroid : IMobile
    {
        string GetAndroidOS();
    }
}
