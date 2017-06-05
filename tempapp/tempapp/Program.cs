using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tempapp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string filename = @"C:\temp\PPC_CI_APIANALOG_25.XEM";
            using (StreamReader streamReader = new StreamReader(filename))
            {
                string line;
                int j = 1000, i = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.Contains("analog.1.curval"))
                    {
                        line = Regex.Replace(line, "analog.1.curval", "analog." + j + ".curval");
                        sb.Append(line);
                        i++;
                        if (i == 2)
                        {
                            i = 0;
                            j++;
                        }
                    }
                    else
                    {
                        sb.Append(line);
                    }
                }
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
            {
                file.Write(sb);
            }
        }
    }
}
