using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class ConcreteObject1 : IFlyweightable
    {
        public void Print()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
