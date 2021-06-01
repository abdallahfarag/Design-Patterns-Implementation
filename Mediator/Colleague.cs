using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Colleague
    {
        protected Mediator _mediator;
        protected Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void Notify (string message);
    }
}
