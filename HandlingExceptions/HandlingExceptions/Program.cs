using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //exceptions happen during runtime. They tend to happen from not handling all possible cases in the code,
            //or relying on a network/other resource, or on user input.
            //Solution: Code defensively.

            //In the end, recall the handling of exceptions is primarily for the benefit of the end-user.

            try
            {
                string content = File.ReadAllText(@"D:\Users\Tyler\Documents\Visual Studio 2015\Projects\HandlingExceptions\HandlingExceptions");
                Console.WriteLine(content);
                
            }
            catch(UnauthorizedAccessException uex)
            {
                Console.WriteLine("There was a problem!\nNot allowed to access file.");
                Console.WriteLine(uex.Message);
            }


            catch(Exception ex)
            {
                Console.WriteLine("There was a problem!\n");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}