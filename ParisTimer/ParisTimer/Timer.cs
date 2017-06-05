using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisTimer
{
    public class Timer
    {
        public Timer(string date, string message)
        {
            int Flag = 1;

            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            while (Flag != 0)
            {
                DateTime myTime = DateTime.ParseExact(date, "dd/MM/yyyy", cultureInfo);
                TimeSpan wait = myTime.Subtract(DateTime.Now);
                wait.Add(new TimeSpan(20));
                int days = wait.Days;
                int hours = wait.Hours;
                int minutes = wait.Minutes;
                int seconds = wait.Seconds;
                int ms = wait.Milliseconds;

                Console.WriteLine(message + "{0} days, {1} hours, {2} minutes, {3} seconds, {4} ms\n",
                    days, hours, minutes, seconds, ms);
                Console.WriteLine("Type \"u\" to update\n");
                var response = Console.ReadLine();

                if (response.ToUpper() != "U")
                {
                    Flag = 0;
                }
            }

            Console.WriteLine("=)");
            Console.ReadLine();

        }
    }
}
