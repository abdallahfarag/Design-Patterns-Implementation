using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class MainApp
    {
        static void Main()
        {
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("How are you?");
            colleague2.Send("Fine Thanks.");
        }
    }
}
