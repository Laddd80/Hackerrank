using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SockMerchant
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            int pairs = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (ar[j]>0 && ar[i] == ar[j])
                    {
                        pairs++;
                        ar[j] = -1;
                        ar[i] = -1;
                    }
                }
            }
            return pairs;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
