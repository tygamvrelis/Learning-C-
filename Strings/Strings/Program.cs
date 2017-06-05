using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Go to your C:\\ drive";//shows one \. \ is an escape character.

            Console.WriteLine(myString);
            Console.ReadLine();

            string myString2 = "MY \"so-called\" string";
            Console.WriteLine(myString2);
            Console.ReadLine();

            string myString3 = "My \nNEWLINE =D";
            Console.WriteLine(myString3);
            Console.ReadLine();

            string myString4 = string.Format("Make: {0} (Model: {1})", "BMW", "760i");
            Console.WriteLine(myString4);
            Console.ReadLine();

            string myString5 = string.Format("{0:C}", 123.45);
            Console.WriteLine(myString5);
            Console.ReadLine();

            string myString6 = string.Format("{0:N}", 12345678);
            Console.WriteLine(myString6);
            Console.ReadLine();

            string myString7 = string.Format("Phone number: {0:+#(###)-###-####}", 14039710040);
            Console.WriteLine(myString7);
            Console.ReadLine();

            StringBuilder myString8 = new StringBuilder();

            for (int i = 0; i<100; i++)
            {
                myString8.Append("--");
                myString8.Append(i);
            }
            Console.WriteLine(myString8);
            Console.ReadLine();

            string squa = "My roflcopter goes SOISOISOISOISOISOI";

            string squat = squa.Substring(0, 22);

            Console.WriteLine(squa);
            Console.ReadLine();
            Console.WriteLine(squat);
            Console.ReadLine();

            string squats = squa.Replace("SOI", "SQUA");

            Console.WriteLine(squats);
            Console.ReadLine();
        }
    }
}
