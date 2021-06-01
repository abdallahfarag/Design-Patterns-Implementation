using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.Pizza_Subsystem
{
    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizaa()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting non veg. pizza...");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting veg. pizza...");
        }

        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings...");
        }
    }
}
