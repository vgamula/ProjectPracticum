using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteBridge1 : AbstractBridge
    {
        public override void Execute()
        {
            this._executor.DoOperation();
        }
    }
}
