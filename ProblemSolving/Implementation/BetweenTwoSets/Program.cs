using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BetweenTwoSets
{
    class Program
    {
        static int getTotalX(int[] a, int[] b)
        {
            List<int> evenly = new List<int>();
            int factorCount = 0;

            for (int i = a[0]; i <= b[0]; i++)
            {
                bool factor = true;
                for (int j = 0; j <a.Length ; j++)
                {
                    if (i % a[j] != 0)
                    {
                        factor = false;
                    }
                }
                if (factor)
                {
                    evenly.Add(i);
                }
            }

            foreach (int item in evenly)
            {
                bool factor = true;
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i] % item != 0)
                    {
                        factor = false;
                    }
                }
                if (factor)
                {
                    factorCount++;
                }
            }
            return factorCount;
        }
        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
            ;
            int total = getTotalX(a, b);

            tw.WriteLine(total);

            tw.Flush();
            tw.Close();
        }
    }
}
