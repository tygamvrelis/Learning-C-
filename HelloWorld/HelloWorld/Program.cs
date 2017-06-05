using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            string y = "Tyler";
            string z = "42";
            string myString = x.ToString() + y;//the ToString() method takes a data type and makes it into a string.

            int tryTwo = x + int.Parse(z);//int.Parse() takes a string of a number and makes it into an integer. 
                                            // Note well that if the string was not a string of a number, this would not work.

          //  Console.WriteLine(myString);
            Console.WriteLine(tryTwo);
            Console.ReadLine();
        }
    }
}
