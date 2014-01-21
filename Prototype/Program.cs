using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ProtorypeClass prototype1 = new ProtorypeClass();
            prototype1.SomeValue = 1;
            Console.WriteLine(String.Format("Prototype: {0}", prototype1));

            ProtorypeClass copiedPrototype = prototype1.Clone() as ProtorypeClass;
            Console.WriteLine(String.Format("Copied prototype: {0}", copiedPrototype));

            Console.WriteLine("_____________________________");
            Console.WriteLine("Using references: ");
            ProtorypeClass refToProtorype = prototype1;
            prototype1.SomeValue = 2;
            Console.WriteLine(refToProtorype);
            Console.WriteLine("_____________________________");

            Console.WriteLine("Using prototype: ");
            ProtorypeClass newProtorype = prototype1.Clone() as ProtorypeClass;
            prototype1.SomeValue = 5;
            Console.WriteLine(newProtorype);      //must be 2
            Console.WriteLine("_____________________________");

            Console.ReadLine();
        }
    }
}
