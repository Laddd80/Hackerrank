using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEquation
{
    class Program
    {
        static int[] permutationEquation(int[] p)
        {
            int[] a = new int[p.Length];

            for (int i = 1; i <= p.Length; i++)
            {
                int firstStep = Array.IndexOf(p, i) + 1;
                int secondStep = Array.IndexOf(p, firstStep) + 1;
                a[i - 1] = secondStep;
            }
            return a;
        }

        static void Main(string[] args)
        {
            /*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
            ;
            int[] result = permutationEquation(p);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
