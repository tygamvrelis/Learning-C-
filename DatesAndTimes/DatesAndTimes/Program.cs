using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine("...");
            Console.WriteLine(myValue.AddDays(3));
            Console.ReadLine();

            DateTime Paris = new DateTime(2016, 07, 12);
            Console.WriteLine(Paris.ToShortDateString());
            Console.WriteLine(Paris.Subtract(myValue));
            Console.ReadLine();

        }
    }
}
