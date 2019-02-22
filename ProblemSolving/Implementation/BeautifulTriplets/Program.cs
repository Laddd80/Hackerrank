using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulTriplets
{
    class Program
    {
        static int beautifulTriplets(int d, int[] arr)
        {
            int count = 0;
            int hossz = arr.Length;
            for (int k = 2; k < hossz; k++)
            {
                for (int j = 1; j < k; j++)
                {
                    if (arr[k]-arr[j] == d)
                    {
                        for (int i = 0; i < j; i++)
                        {
                            if (arr[j] - arr[i]  == d)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = beautifulTriplets(d, arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
