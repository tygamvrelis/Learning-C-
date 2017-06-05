using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoclicker
{
    public class Clicker
    {
        #region clicker
        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            System.Threading.Thread.Sleep(5);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
        #endregion


        #region delay times and test flag for the print fucntions
        static int STANDARD_DELAY = 15 * 60 * 1000;//fifteen mins
        static int ATYPICAL_DELAY = 10 * 60 * 1000;//ten mins

        public static bool testFlag = false;//set to true to run a faster test for the printClickProgress function.
        #endregion


        //for testing purposes.
        public static void testPrintClickProgress(int window, int iteration, DateTime recStart)
        {
            int TEST_STANDARD_DELAY = STANDARD_DELAY / 60;
            int TEST_ATYPICAL_DELAY = ATYPICAL_DELAY / 60;
            window = window / 60;

            Console.WriteLine("Recording number: {0}", iteration + 1);
            if (iteration == 0)
            {
                System.Threading.Thread.Sleep(TEST_STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} sec", DateTime.Now, DateTime.Now.Subtract(recStart));
                System.Threading.Thread.Sleep(TEST_STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} sec", DateTime.Now, DateTime.Now.Subtract(recStart));
                System.Threading.Thread.Sleep(TEST_STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} sec", DateTime.Now, DateTime.Now.Subtract(recStart));
                System.Threading.Thread.Sleep(TEST_ATYPICAL_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} sec", DateTime.Now, DateTime.Now.Subtract(recStart));

                Console.WriteLine("{0} Stopping recording...", DateTime.Now);
            }
            else
            {
                System.Threading.Thread.Sleep(window);//numVids * latencyBetweenRecordings
                Console.WriteLine("{0} Latency propagation complete.", DateTime.Now);
                System.Threading.Thread.Sleep(TEST_STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} sec", DateTime.Now, DateTime.Now.Subtract(recStart).TotalSeconds);
                System.Threading.Thread.Sleep(TEST_STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} sec", DateTime.Now, DateTime.Now.Subtract(recStart).TotalSeconds);
                System.Threading.Thread.Sleep(TEST_STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} sec", DateTime.Now, DateTime.Now.Subtract(recStart).TotalSeconds);
                System.Threading.Thread.Sleep(TEST_ATYPICAL_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} sec", DateTime.Now, DateTime.Now.Subtract(recStart).TotalSeconds);

                Console.WriteLine("{0} Stopping recording...", DateTime.Now);
            }
        }


        //regular function to print the progress of the current recording.
        public static void printClickProgress(int window, int iteration, DateTime recStart)
        {
            Console.WriteLine("Recording number: {0}", iteration + 1);
            if (iteration == 0)
            {
                System.Threading.Thread.Sleep(STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} min", DateTime.Now, DateTime.Now.Subtract(recStart).TotalMinutes);
                System.Threading.Thread.Sleep(STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} min", DateTime.Now, DateTime.Now.Subtract(recStart).TotalMinutes);
                System.Threading.Thread.Sleep(STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} min", DateTime.Now, DateTime.Now.Subtract(recStart).TotalMinutes);
                System.Threading.Thread.Sleep(ATYPICAL_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} min", DateTime.Now, DateTime.Now.Subtract(recStart).TotalMinutes);

                Console.WriteLine("{0} Stopping recording...", DateTime.Now);
            }
            else
            {
                System.Threading.Thread.Sleep(window);//numVids * latencyBetweenRecordings. Recordings DO occur during this time.
                Console.WriteLine("{0} Latency propagation complete.", DateTime.Now);
                System.Threading.Thread.Sleep(STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} min", DateTime.Now, DateTime.Now.Subtract(recStart).TotalMinutes);
                System.Threading.Thread.Sleep(STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} min", DateTime.Now, DateTime.Now.Subtract(recStart).TotalMinutes);
                System.Threading.Thread.Sleep(STANDARD_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} min", DateTime.Now, DateTime.Now.Subtract(recStart).TotalMinutes);
                System.Threading.Thread.Sleep(ATYPICAL_DELAY);

                Console.WriteLine("{0} Time elapsed in current recording: {1} min", DateTime.Now, DateTime.Now.Subtract(recStart).TotalMinutes);

                Console.WriteLine("{0} Stopping recording...", DateTime.Now);
            }
        }


        static void Main()
        {
            //initialize setup variables
            string restartFlag = "Y";//set this to "N" to skip the setup and continue with the default values below
            int numVids = 24;
            int xCoord = 960;
            int yCoord = 460;

            //Loop the set-up aspects of the program in case any changes would like to be made without having to quit
            #region setup loop
            while (restartFlag == "Y")
            {
                //Get number of videos
                bool Thrown = true;
                while (Thrown)
                {
                    Console.WriteLine("Please enter the number of videos you would like to record.\n");
                    try
                    {
                        numVids = Convert.ToInt32(Console.ReadLine());
                        Thrown = false;
                    }
                    catch
                    {
                        Console.WriteLine("\n\nInvalid input. Please enter an integer.");
                        Thrown = true;
                    }
                }

                //Get x-coordinate for clicking
                Thrown = true;
                while (Thrown)
                {
                    Console.WriteLine("\n\nPlease enter the x-coordinate where you would like the mouse to click (suggested: 960)\n");
                    try
                    {
                        xCoord = Convert.ToInt32(Console.ReadLine());
                        Thrown = false;
                    }
                    catch
                    {
                        Console.WriteLine("\n\nInvalid input. Please enter an integer.");
                        Thrown = true;
                    }
                }

                //Get y-coordinate for clicking
                Thrown = true;
                while (Thrown)
                {
                    Console.WriteLine("\n\nPlease enter the y-coordinate where you would like the mouse to click (suggested: 460)\n");

                    try
                    {
                        yCoord = Convert.ToInt32(Console.ReadLine());
                        Thrown = false;
                    }
                    catch
                    {
                        Console.WriteLine("\n\nInvalid input. Please enter an integer.");
                        Thrown = true;
                    }
                }


                //Ask if they would like to demo the click to see where the pointer will move to
                string demoString = "lorem ipsum";
                int demoFlag = 0;

                while (demoFlag == 0)
                {
                    Console.WriteLine("\nWould you like to see where the mouse will move to? (Y = yes, N = no)\n");
                    demoString = Console.ReadLine().ToUpper();

                    if (demoString == "Y" || demoString == "YES")
                    {
                        demoFlag = 1;
                    }
                    else if (demoString == "N" || demoString == "NO")
                    {
                        demoFlag = 2;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please try again.\n");
                    }
                }

                if (demoFlag == 1)
                {
                    Console.WriteLine("\n5");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("4");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("3");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("2");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("1");
                    System.Threading.Thread.Sleep(1000);
                    LeftMouseClick(xCoord, yCoord);

                }


                //Ask if settings are satisfactory. Restart setup if not.
                Console.WriteLine("\n\nSummary:\n  Number of videos: {0}\n  xCoord: {1}\n  yCoord: {2}\n", numVids, xCoord, yCoord);
                Console.WriteLine("\nDo you wish to restart? (type \"Y\" for yes, and any other key to begin recordings)");
                restartFlag = Console.ReadLine().ToUpper();
                Console.WriteLine("\n");
            }
            #endregion


            #region Latency computations for loop and loop index initialization
            //20 second latency between recordings to give the Logitech Webcam software adequate time to write to the disk
            int latencyBetweenRecordings = 20 * 1000;

            //The "window" for which we are allowing latency between recordings to propagate
            int latencyPropagationWindow = numVids * latencyBetweenRecordings;

            //index for the loop
            int i = 0;
            #endregion


            #region Countdown
            Console.WriteLine("5");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("4");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("3");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1");
            System.Threading.Thread.Sleep(1000);
            #endregion

            DateTime recStart = DateTime.Now;

            //loop through the recordings now
            for (i = 0; i < numVids; i++)
            {

                //CASE 1: No latency time prior to recording
                if (i == 0)
                {
                    LeftMouseClick(xCoord, yCoord);
                    Console.WriteLine("\n\n{0} Starting recordings...", DateTime.Now);

                    if (testFlag == true)
                    {
                        testPrintClickProgress(latencyPropagationWindow, i, recStart);
                    }
                    else
                    {
                        printClickProgress(latencyPropagationWindow, i, recStart);
                    }

                    LeftMouseClick(xCoord, yCoord);

                    System.Threading.Thread.Sleep(latencyBetweenRecordings);//20 sec
                }

                //CASE 2: factors in latency time between the recordings
                else
                {
                    recStart = DateTime.Now;
                    LeftMouseClick(xCoord, yCoord);
                    Console.WriteLine("\n\n{0} Starting next recording...", DateTime.Now);

                    if (testFlag == true)
                    {
                        testPrintClickProgress(latencyPropagationWindow, i, recStart);
                    }
                    else
                    {
                        printClickProgress(latencyPropagationWindow, i, recStart);
                    }

                    LeftMouseClick(xCoord, yCoord);

                    System.Threading.Thread.Sleep(latencyBetweenRecordings);//20 sec
                }
            }
            Console.WriteLine("Videos recorded.");
            Console.ReadLine();
        }
    }
}
