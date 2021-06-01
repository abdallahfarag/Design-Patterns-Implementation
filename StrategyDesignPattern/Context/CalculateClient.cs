using StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Context
{
    public class CalculateClient
    {
        ICalculateStrategy _calculateStrategy;
        public CalculateClient(ICalculateStrategy calculateStrategy)
        {
            _calculateStrategy = calculateStrategy;
        }

        public int Calculate(int val1, int val2)
        {
            return _calculateStrategy.Calculate(val1, val2);
        }
    }
}
