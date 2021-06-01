using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.Bread_Subsystem
{
    public class BreadProvider : IBread
    {
        public void GetCheesyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting cheesy garlic bread...");
        }

        public void GetGarlicBread()
        {
            Console.WriteLine("Getting garlic bread...");
        }

        private void GetCheese()
        {
            Console.WriteLine("Getting cheese...");
        }
    }
}
