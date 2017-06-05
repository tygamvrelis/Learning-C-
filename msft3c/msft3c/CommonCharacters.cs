using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msft3c
{
    public static class CommonCharacters
    {
        public static void Load()
        {
            string path = @"D:\Users\Tyler\Documents\Visual Studio 2015\Projects\msft3c\PracticeInput.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int flag = 0, numTests = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    
                    if(flag == 0)
                    {
                        Int32.TryParse(line, out numTests);
                        flag = 1;
                        continue;
                    }

                    string[] words;
                    words = line.Split(' ');
                    
                    List<string> myStrings = new List<string>();

                    foreach (string s in words)
                    {
                        myStrings.Add(s);
                    }

                    List<char[]> myIntersections = new List<char[]>();

                    for (int x = 0; x < words.Length; x++)
                    {
                        Console.WriteLine(myStrings[x]);
                        Console.WriteLine(myStrings[x + 1]);
                        char[] s2 = myStrings[x + 1].ToCharArray();
                        char[] s1 = myStrings[x].ToCharArray();

                        var common = s1.Intersect(s2);

                        StringBuilder sb = new StringBuilder();
                        foreach (char v in common)
                        {
                            sb.Append(v);
                        }

                        myStrings[x + 1] = sb.ToString();
                        Console.WriteLine(myStrings[x + 1]);
                        Console.ReadLine();
                    }
                    Console.WriteLine(myStrings[myStrings.Count]);
                    Console.ReadLine();
                }
            }
        }
    }
}
