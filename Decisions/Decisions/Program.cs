using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose 1, 2, or 3.");
            string userValue = Console.ReadLine();

            //string message = "";

            //if (uservalue == "1")
            //    message = "you chose 1.";
            //else if (uservalue == "2")
            //    message = "you chose 2.";
            //else if (uservalue == "3")
            //    message = "you chose 3.";
            //else
            //    message = "wow that's not one of the choices.";

            string message = (userValue == "1") ? "fish" : "nothing";

            Console.WriteLine("You won a {0} {1}", message, userValue);
            Console.ReadLine();
            Console.WriteLine(1);
            Console.ReadLine();
        }
    }
}
