using FacadeDesignPattern.Bread_Subsystem;
using FacadeDesignPattern.Pizza_Subsystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.Facade
{
    public class RestaurantFacade
    {
        private IPizza _pizza;
        private IBread _bread;

        public RestaurantFacade()
        {
            _pizza = new PizzaProvider();
            _bread = new BreadProvider();
        }

        public void GetVegPizza()
        {
            _pizza.GetVegPizza();
        }
        public void GetNonVegPizza()
        {
            _pizza.GetNonVegPizaa();
        }
        public void GetGarlicBread()
        {
            _bread.GetGarlicBread();
        }
        public void GetCheesyGarlicBread()
        {
            _bread.GetCheesyGarlicBread();
        }
    }
}
