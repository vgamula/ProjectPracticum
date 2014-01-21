using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ConcreteFactory1 : AbstractFactory
    {
        protected override AbstractObject CreateObject(string type)
        {
            AbstractObject obj = null;
            switch (type)
            {
                case "ConcreteObject1": obj = new ConcreteObject1(); break;
                case "ConcreteObject2": obj = new ConcreteObject2(); break;
                default: obj = null; break;
            }
            return obj;
        }
    }
}
