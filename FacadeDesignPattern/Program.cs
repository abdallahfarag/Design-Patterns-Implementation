using FacadeDesignPattern.Facade;
using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantFacade restaurantFacade = new RestaurantFacade();
            restaurantFacade.GetNonVegPizza();
            restaurantFacade.GetCheesyGarlicBread();
        }
    }
}
