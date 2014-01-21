using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class AbstractFactory
    {
        public AbstractObject GetObject(String type)
        {
            AbstractObject obj = CreateObject(type);
            return obj;
        }

        protected abstract AbstractObject CreateObject(String type);
    }
}
