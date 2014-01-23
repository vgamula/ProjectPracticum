using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFactory factory = new ObjectFactory();

            IFlyweightable obj = factory.GetObject("ConcreteObject1");
            obj.Print();
            obj = factory.GetObject("ConcreteObject2");
            obj.Print();
            obj = factory.GetObject("ConcreteObject1");
            obj.Print();
            obj = factory.GetObject("ConcreteObject2");
            obj.Print();

            Console.WriteLine(String.Format("Amount of created objects: {0}", factory.CreatedObjectsAmount));

            Console.ReadLine();
        }
    }
}
