using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Year = 2010;
            myCar.Make = "Ford";
            myCar.Model = "Escape";
            myCar.Color = "Charcoal Grey";

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Year = 2006;
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;
            printVehicleDetails(myTruck);

            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the car's details: {0}", vehicle.FormatMe());
        }
    }

    abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe();
    }

    class Car : Vehicle
    {
        public override string FormatMe()
        {
            return string.Format("{0} - {1} - {2} - {3}",
                this.Year,
                this.Make,
                this.Model,
                this.Color);
        }
    }

    sealed class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe()
        {
            return string.Format("{0} - {1} - Towing units: {2}",
                this.Year,
                this.Make,
                this.TowingCapacity);
        }
    }
    /*
    class Semi : Truck
    {
        //won't work because Truck is sealed
    }
    */
}
