using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumDistances
{
    class Program
    {
        static int minimumDistances(int[] a)
        {
            int min = int.MaxValue;

            int hossz = a.Length;
            for (int i = 0; i < hossz-1; i++)
            {
                for (int j = i+1; j < hossz; j++)
                {
                    if (a[i] == a[j])
                    {
                        if (j-i < min)
                        {
                            min = j - i;
                        }
                    }
                }
            }

            if (min == int.MaxValue)
            {
                min = -1;
            }
            return min;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int result = minimumDistances(a);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
