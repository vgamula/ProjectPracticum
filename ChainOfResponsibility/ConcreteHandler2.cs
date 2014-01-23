using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHandler2 : AbstractHandler
    {
        public override void HandleRequest(int value)
        {
            if (value >= 11 && value <= 20)
            {
                Console.WriteLine(String.Format("{0} is nandled by {1}", value, this.GetType().Name));
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(value);
            }
            else
            {
                Console.WriteLine("Cant handle {0}", value);
            }
        }
    }
}
