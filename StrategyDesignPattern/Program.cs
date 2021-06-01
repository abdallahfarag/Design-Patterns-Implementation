using StrategyDesignPattern.ConcreteStrategy;
using StrategyDesignPattern.Context;
using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apply subtraction strategy
            CalculateClient minusCalculateObj = new CalculateClient(new MinusStrategy());
            Console.WriteLine("Subtraction calculation result : " + minusCalculateObj.Calculate(50, 40));

            //Apply Addition strategy
            CalculateClient plusCalculateObj = new CalculateClient(new PlusStrategy());
            Console.WriteLine("Addition calculation result : " + plusCalculateObj.Calculate(50, 40));
        }
    }
}
