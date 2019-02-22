using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLane
{
    class Program
    {
        static int[] serviceLane(int n, int[][] cases, int[] width, int t)
        {
            int[] result = new int[t];
            for (int i = 0; i < t; i++)
            {
                int start = cases[i][0];
                int exit = cases[i][1];

                int max = int.MaxValue;

                for (int j = start; j <= exit; j++)
                {
                    if (width[j] < max)
                    {
                        max = width[j];
                    }
                }

                result[i] = max;
            }
            return result;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nt = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nt[0]);

            int t = Convert.ToInt32(nt[1]);

            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp))
            ;

            int[][] cases = new int[t][];

            for (int i = 0; i < t; i++)
            {
                cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            int[] result = serviceLane(n, cases, width, t);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
