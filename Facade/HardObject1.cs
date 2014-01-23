﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class HardObject1
    {
        public void DoAction1()
        {
            Console.WriteLine("Do Action1 in " + this.GetType().Name);
        }
        public void DoAction2()
        {
            Console.WriteLine("Do Action2 in " + this.GetType().Name);
        }
    }
}
