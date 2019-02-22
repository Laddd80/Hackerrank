using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountingValleys
{
    class Program
    {
        static int countingValleys(int n, string s)
        {
            int level = 0;
            int valleysCount =0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    level++;
                    if (level == 0)
                    {
                        valleysCount++;
                    }
                }
                else
                {
                    level--;
                }
            }
            return valleysCount;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
