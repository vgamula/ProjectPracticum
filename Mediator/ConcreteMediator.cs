using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteMediator : AbstractMediator
    {
        private List<AbstractObject> _mediators = new List<AbstractObject>();

        public override void Send(string message, AbstractObject obj)
        {
            foreach (AbstractObject item in this._mediators)
            {
                if (obj == item)
                    continue;
                item.Notify(message);
            }
        }

        public override void AddObject(AbstractObject obj)
        {
            if (!this._mediators.Contains(obj))
            {
                this._mediators.Add(obj);
            }
        }
    }
}
