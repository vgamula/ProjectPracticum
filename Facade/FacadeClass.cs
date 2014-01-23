using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class FacadeClass
    {
        private HardObject1 hardObject1;
        private HardObject2 hardObject2;
        private HardObject3 hardObject3;

        public FacadeClass(HardObject1 ho1, HardObject2 ho2, HardObject3 ho3)
        {
            this.hardObject1 = ho1;
            this.hardObject2 = ho2;
            this.hardObject3 = ho3;
        }

        public void DoAction1()
        {
            this.hardObject1.DoAction1();
            this.hardObject2.DoAction1();
            this.hardObject3.DoAction1();
        }

        public void DoAction2()
        {
            this.hardObject1.DoAction2();
            this.hardObject2.DoAction2();
            this.hardObject3.DoAction2();
        }
    }
}
