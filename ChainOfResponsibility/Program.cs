using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteHandler1 mainHandler = new ConcreteHandler1();
            mainHandler.Successor = new ConcreteHandler2();
            mainHandler.Successor.Successor = new ConcreteHandler3();

            int[] requests = { 0, 5, 9, 11, 18, 25, 29, 34};

            foreach (var item in requests)
            {
                mainHandler.HandleRequest(item);
            }

            Console.ReadLine();
        }
    }
}
