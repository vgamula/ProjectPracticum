using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteObject : AbstractObject
    {
        public String Name { get; set; }

        public ConcreteObject(AbstractMediator mediator): base(mediator)
        {

        }

        public override void Send(string message)
        {
            Console.WriteLine(String.Format("{0} says: '{1}'", this.Name, message));
            this._mediator.Send(String.Format("'{0}' from {1}", message, this.Name), this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine(String.Format("{0} recieved message: {1}", this.Name, message));
        }

    }
}
