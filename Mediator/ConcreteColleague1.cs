using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator):base(mediator)
        {

        }
        public override void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: "+ message);
        }
    }
}
