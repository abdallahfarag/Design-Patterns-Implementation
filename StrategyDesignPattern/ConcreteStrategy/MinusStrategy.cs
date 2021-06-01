using StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.ConcreteStrategy
{
    public class MinusStrategy : ICalculateStrategy
    {
        public int Calculate(int val1, int val2)
        {
            return val1 - val2;
        }
    }
}
