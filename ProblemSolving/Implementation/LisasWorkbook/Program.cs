using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisasWorkbook
{
    class Program
    {
        static int workbook(int n, int k, int[] arr)
        {
            int spec = 0;
            int page = 1; ;

            for (int i = 1; i <= n; i++)
            {
                int problems = arr[i-1];

                for (int j = 1; j <= problems; j++)
                {
                    if (j == page)
                    {
                        spec++;
                    }
                    if (j % k == 0 || j == problems)
                    {
                        page++;
                    }
                }             
            }
            return spec;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = workbook(n, k, arr);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
