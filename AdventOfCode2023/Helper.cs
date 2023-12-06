using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023
{
    public static class Helper
    {

        public static List<string> GetInput(string filename)
        {
            var output = new List<string>();
            
            StreamReader sr = new StreamReader(@"C:\Users\marts\source\repos\AdventOfCode2023\AdventOfCode2023\" + filename);
            var line = sr.ReadLine();
            while (line != null)
            {
                output.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();

            return output;
        }
    }
}
