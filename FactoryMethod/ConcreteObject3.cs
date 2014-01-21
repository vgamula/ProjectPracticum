using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ConcreteObject3 : AbstractObject
    {
        public ConcreteObject3()
        {
            this.Name = this.GetType().Name;
        }
    }
}
