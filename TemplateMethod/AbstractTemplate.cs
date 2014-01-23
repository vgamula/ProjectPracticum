using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class AbstractTemplate
    {
        public void Execute()
        {
            DoAction1();
            DoAction2();
            DoAction3();
            DoAction4();
        }

        public void DoAction1()
        {
            Console.WriteLine("Doing Action1");
        }

        public void DoAction3()
        {
            Console.WriteLine("Doing Action3");
        }

        public abstract void DoAction2();

        public abstract void DoAction4();

    }
}
