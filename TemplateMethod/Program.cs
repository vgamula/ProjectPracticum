using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractTemplate concreteObject1 = new ConcreteObject1();
            AbstractTemplate concreteObject2 = new ConcreteObject2();

            concreteObject1.Execute();

            Console.WriteLine("--------------");

            concreteObject2.Execute();

            Console.ReadLine();
        }
    }
}
