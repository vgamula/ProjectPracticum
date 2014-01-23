using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class ViewName : AbstractView
    {
        public override void Render(object obj = null)
        {
            if (obj != null)
                Console.WriteLine("Your name is: {0}", obj.ToString());
        }

        public override object RenderWithResponse(object obj = null)
        {
            if (obj != null)
                Console.WriteLine(obj);
            return (Object)Console.ReadLine();
        }
    }
}
