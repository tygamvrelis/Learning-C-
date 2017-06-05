using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            var bmws = from car in myCars where car.Make == "BMW" select car;

            foreach (var car in bmws)
            {
                Console.WriteLine("{0}, {1}", car.Model, car.VIN);
            }

            Console.ReadLine();

            var bmwz = myCars.Where(p=> p.Make == "BMW" && p.Year ==2010);

            foreach (var car in bmwz)
            {
                Console.WriteLine("{0}, {1}", car.Model, car.VIN);
            }

            Console.ReadLine();

            Console.WriteLine("\nNext two...\n");
            var bmews = myCars.OrderByDescending(p => p.Year);

            foreach (var car in bmews)
            {
                Console.WriteLine("{0}, {1}", car.Model, car.VIN);
            }

            Console.ReadLine();

            var bemws = from car in myCars orderby car.Year descending select car;

            foreach (var car in bemws)
            {
                Console.WriteLine("{0}, {1}", car.Model, car.VIN);
            }

            Console.ReadLine();

            Console.WriteLine(myCars.First(p => p.Make == "BMW").VIN);

            Console.ReadLine();

            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            Console.ReadLine();

            myCars.ForEach(p => Console.WriteLine("{0}, {1:C}", p.VIN, p.StickerPrice));

            Console.ReadLine();

            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            Console.ReadLine();

            Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            Console.ReadLine();

            Console.WriteLine(myCars.GetType());

            Console.ReadLine();

            Console.WriteLine(myCars.OrderByDescending(p => p.Year).GetType());

            Console.ReadLine();

            var newBMWs = from car in myCars where car.Make == "BMW" select new { car.Make, car.Model };

            Console.WriteLine(newBMWs.GetType());

            Console.ReadLine();


        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
