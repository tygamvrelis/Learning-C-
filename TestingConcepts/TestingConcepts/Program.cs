using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing inheritance of private const members used in base methods
            Derived2 d2 = new Derived2();
            printVersion(d2.VersionName);
        }

        public static void printVersion(string version)
        {
            Console.WriteLine("Version: {0}", version);
            Console.ReadLine();
        }
    }
}
