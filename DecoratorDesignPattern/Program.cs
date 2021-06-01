using DecoratorDesignPattern.Android_Interface;
using DecoratorDesignPattern.Mobile_Type;
using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAndroid android = new Android();
            OnePlus onePlus = new OnePlus(android);

            Console.WriteLine($"{onePlus.GetModel()}\n {onePlus.GetAndroidOS()} \n Price: {onePlus.GetPrice()}");

        }
    }
}
