using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Strategy
{
    public interface ICalculateStrategy
    {
        int Calculate(int val1, int val2);
    }
}
