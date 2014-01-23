using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteObject obj1 = new ConcreteObject(mediator) { Name = "obj1" };
            ConcreteObject obj2 = new ConcreteObject(mediator) { Name = "obj2" };
            ConcreteObject obj3 = new ConcreteObject(mediator) { Name = "obj3" };

            obj1.Send("Hello, World!");
            Console.WriteLine("---------");
            obj2.Send("Hi, my name is vaka-vaka");
            Console.WriteLine("---------");
            obj3.Send("Yo-yo-yo, Albuquerque");


            Console.ReadLine();
        }
    }
}
