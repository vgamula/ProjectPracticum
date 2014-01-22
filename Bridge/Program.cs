using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteBridge1 bridge = new ConcreteBridge1();
            ConcreteExecutor1 executor1 = new ConcreteExecutor1();
            ConcreteExecutor2 executor2 = new ConcreteExecutor2();

            bridge.Executor = executor1;
            bridge.Execute();

            bridge.Executor = executor2;
            bridge.Execute();

            Console.ReadLine();
        }
    }
}
