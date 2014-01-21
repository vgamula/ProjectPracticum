using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ConcreteObject2 : AbstractObject
    {
        public ConcreteObject2()
        {
            this.Name = this.GetType().Name;
        }
    }
}
