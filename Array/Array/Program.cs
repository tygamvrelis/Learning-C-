using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[5];
            //int i = 0;

            //for (i = 0; i < 5; i++)
            //{
            //    array[i] = 4 * i + 2;
            //}

            //Console.WriteLine(array[2]);
            //Console.ReadLine();

            //int[] array2 = new int[] { 1, 2, 3, 4, 5, 42 };

            //foreach (int squa in array2)
            //{
            //    Console.WriteLine(squa);
            //}
            //Console.ReadLine();

            string zig = "You can get what you want in life if you can help enough other people get what they want in life";

            char[] charArray = zig.ToCharArray();//char type can store a SINGLE alphanumeric character. ToCharArray() chops
                                                //up a string into an array of chars.
            Array.Reverse(charArray);//reverses ordinal position of each char in array.

            Console.WriteLine(charArray.Length);
            Console.ReadLine();

            foreach (char zigChar in charArray)
                Console.Write(zigChar);

            Console.ReadLine();
        }
    }
}
