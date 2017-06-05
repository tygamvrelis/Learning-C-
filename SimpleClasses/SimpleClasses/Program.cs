using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Escape";
            myCar.Year = 2010;
            myCar.Color = "Charcoal Grey";

            Console.WriteLine("{0} {1} {2}, {3}",
                myCar.Year,
                myCar.Make,
                myCar.Model,
                myCar.Color);

            Console.ReadLine();

            Console.WriteLine("Price: {0:C}", getCurrValue(myCar));
            Console.ReadLine();

        }

        private static double getCurrValue(Car car)
        {
            double carValue = 30000.00;
            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

    }
}
