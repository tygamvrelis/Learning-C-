using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a skater's name for his IG.");
            string response = Console.ReadLine();

            switch (response.ToUpper())
            {
                case "DARREN":
                    Console.WriteLine("darrenmac11");
                    break;
                case "TYLER":
                    Console.WriteLine("tygamvrelis");
                    break;
            }
            Console.ReadLine();
        }
    }
}
