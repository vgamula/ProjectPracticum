using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class AbstractObject
    {
        protected AbstractMediator _mediator;

        public AbstractObject(AbstractMediator mediator)
        {
            this._mediator = mediator;
            this._mediator.AddObject(this);
        }

        public abstract void Send(String message);

        public abstract void Notify(String message);
    }
}
