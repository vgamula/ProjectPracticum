using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    abstract class AbstractView
    {
        public abstract void Render(Object obj = null);
        public abstract object RenderWithResponse(Object obj = null);
    }
}
