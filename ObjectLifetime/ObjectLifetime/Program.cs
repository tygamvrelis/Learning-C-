using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.myMethod();


        }
    }

    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            this.Make = "Nissan";
        }

        public Car(int year, string make, string model, string color)
        {
            Year = year;//because local variables defined within the scope of the class already (?)
            Make = make;
            Model = model;
            Color = color;
        }

        public static void myMethod()
        {
            int g = 2;
        }

    }
}
