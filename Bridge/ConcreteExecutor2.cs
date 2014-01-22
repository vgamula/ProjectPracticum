using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteExecutor2 : AbstractExecutor
    {
        public override void DoOperation()
        {
            Console.WriteLine(String.Format("Operation: {0}", this.GetType().Name));
        }
    }
}
