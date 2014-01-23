using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class AbstractMediator
    {
        public abstract void Send(String message, AbstractObject obj);
        public abstract void AddObject(AbstractObject obj);
    }
}
