using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeClass facade = new FacadeClass(new HardObject1(), new HardObject2(), new HardObject3());

            facade.DoAction1();
            Console.WriteLine("---------------");
            facade.DoAction2();
            
            Console.ReadLine();
        }
    }
}
