using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class ObjectFactory
    {
        private Dictionary<String, IFlyweightable> objects = new Dictionary<string, IFlyweightable>();

        public int CreatedObjectsAmount 
        { 
            get 
            {
                return objects.Count;
            } 
        }

        public IFlyweightable GetObject(String objectName)
        {
            IFlyweightable obj = null;
            if (objects.ContainsKey(objectName))
            {
                obj = objects[objectName];
                return obj;
            }
            switch (objectName)
            {
                case "ConcreteObject1":
                    obj = new ConcreteObject1();
                    objects.Add(objectName, obj);
                    break;
                case "ConcreteObject2":
                    obj = new ConcreteObject2();
                    objects.Add(objectName, obj);
                    break;
            }
            return obj;
        }


    }
}
