using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class AbstractHandler
    {
        public AbstractHandler Successor { get; set; }

        public abstract void HandleRequest(int value);
    }
}
