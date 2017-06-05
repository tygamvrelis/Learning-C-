using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hello world");
            Console.ReadLine();

            List<ToDo> ToDos = new List<ToDo>()
            {
                new ToDo { Description = "Task 1", EstHours = 6, Status = Status.on}
            };

            print(ToDos);
            Console.ReadLine();
        }

        private static void print(List<ToDo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.on:
                        Console.WriteLine("Nice!");
                        break;
                    case Status.off:
                        break;
                    case Status.delayed:
                        break;
                    case Status.transit:
                        break;
                    default:
                        break;
                }
            }
        }
    }

    class ToDo
    {
        public string Description { get; set; }
        public int EstHours { get; set; }
        public Status Status { get; set; }

    }
    enum Status
    {
        on,
        off,
        delayed,
        transit
    }
}
