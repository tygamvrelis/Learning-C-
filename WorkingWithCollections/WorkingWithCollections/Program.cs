using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "C2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            //Legacy collection
            */

            //List<T>

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            //Dictionary<TKey, TValue> — Pairs of keys and values

            Dictionary<string, Car> myDict = new Dictionary<string, Car>();

            myDict.Add(car1.VIN, car1);
            myDict.Add(car2.VIN, car2);

            Console.WriteLine("\n" + myDict["C2"].Make);

            Console.ReadLine();

            Console.WriteLine("Collection initializer");

            List<Car> myL = new List<Car>()//collection initializer
            {
                new Car { Make = "Ford", Model = "Escape", VIN = "R2" },//object initializer
                new Car { Make = "Mazda", Model = "3", VIN = "R3" }//object initializer
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
