using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ConcreteObject1 : AbstractObject
    {
        public ConcreteObject1()
        {
            this.Name = this.GetType().Name;
        }
    }
}
