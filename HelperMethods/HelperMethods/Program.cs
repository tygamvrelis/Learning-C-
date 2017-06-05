using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = superSecretFormula();
            Console.WriteLine(myValue);
            Console.ReadLine();
            Console.WriteLine(superSecretFormula("mother"));
            Console.ReadLine();
        }

        private static string superSecretFormula()//We'd get an error if we put this method anywhere else except in the Program class
        {
            return "Hello World!";
        }

        private static string superSecretFormula(string x)
        {
            return String.Format("Hello, {0}", x);
        }
    }
}
