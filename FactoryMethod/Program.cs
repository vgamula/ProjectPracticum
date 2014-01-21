using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            AbstractFactory factory2 = new ConcreteFactory2();

            AbstractObject obj1 = factory1.GetObject("ConcreteObject1");
            AbstractObject obj2 = factory2.GetObject("ConcreteObject3");

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.ReadLine();
        }
    }
}
