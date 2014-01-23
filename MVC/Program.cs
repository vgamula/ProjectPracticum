using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeController controller = new HomeController();
            controller.PrintNameAction();

            Console.ReadLine();
        }
    }
}
