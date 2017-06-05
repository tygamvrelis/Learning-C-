using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;//+= attaches (subscribes) new timers to the event

            myTimer.Start();

            Console.WriteLine("Press Enter to remove the cyan event");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed;

            Console.ReadLine();

        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Elaspsed1: {0: HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elaspsed: {0: HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
