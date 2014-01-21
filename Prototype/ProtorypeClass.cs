using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ProtorypeClass : ICloneable
    {
        public Int32 SomeValue { get; set; }

        public ProtorypeClass(Int32 value = 0)
        {
            this.SomeValue = value;
        }

        public override string ToString()
        {
            return String.Format("Value = {0}", this.SomeValue);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
