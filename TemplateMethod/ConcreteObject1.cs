using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcreteObject1 : AbstractTemplate
    {
        public override void DoAction2()
        {
            Console.WriteLine(String.Format("Doing Action2 in {0}", this.GetType().Name));
        }

        public override void DoAction4()
        {
            Console.WriteLine(String.Format("Doing Action4 in {0}", this.GetType().Name));
        }
    }
}
