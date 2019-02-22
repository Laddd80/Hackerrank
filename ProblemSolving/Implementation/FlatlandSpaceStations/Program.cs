using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatlandSpaceStations
{
    class Program
    {
        static int flatlandSpaceStations(int n, int[] c)
        {
            int maxLength = 0;

            c = (from x in c
                 orderby x
                 select x).ToArray();
           

            for (int i = 0; i < c.Length-1; i++)
            {
                if ((c[i+1] - c[i])/2 > maxLength)
                {
                    maxLength = (c[i + 1] - c[i])/2;
                }
            }

            if (c[0] != 0 && c[0]> maxLength)
            {
                maxLength = c[0];
            }
            if (c[c.Length-1] < n-1 && n-1 - c[c.Length-1] > maxLength)
            {
                maxLength = (n-1)-c[c.Length - 1];
            }
            return maxLength;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = flatlandSpaceStations(n, c);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
