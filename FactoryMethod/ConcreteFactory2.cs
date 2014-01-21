using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ConcreteFactory2 : AbstractFactory
    {
        protected override AbstractObject CreateObject(string type)
        {
            AbstractObject obj = null;
            switch (type)
            {
                case "ConcreteObject2": obj = new ConcreteObject2(); break;
                case "ConcreteObject3": obj = new ConcreteObject3(); break;
                default: obj = null; break;
            }
            return obj;
        }
    }
}
