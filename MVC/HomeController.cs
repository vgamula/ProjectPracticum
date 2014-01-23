using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class HomeController : AbstractController
    {
        public void PrintNameAction(Person person = null)
        {
            if (person == null)
            {
                Person prsn = new Person() { Name = (String)(new ViewName()).RenderWithResponse("Enter your name: ") };
                this.PrintNameAction(prsn);
                return;
            }
            (new ViewName()).Render(person);
        }
    }
}
