using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularArrayRotation
{
    class Program
    {
        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int hossz = a.Length;
            
            
            for (int j = 0; j < k; j++)
            {
                int[] ujArray = a;
                int elso = a[hossz-1];
                Array.Copy(a, 0, ujArray, 1, hossz - 1);
                ujArray[0] = elso;
                a = ujArray;
            }

            for (int i = 0; i < queries.Length; i++)
            {
                queries[i] = a[queries[i]];
            }
            return queries;
        }

        static void Main(string[] args)
        {
            /*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nkq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nkq[0]);

            int k = Convert.ToInt32(nkq[1]);

            int q = Convert.ToInt32(nkq[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            int[] result = circularArrayRotation(a, k, queries);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
