using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MigratoryBirds
{
    class Program
    {
        static int migratoryBirds(int[] ar)
        {
            int mostCommonId = -1;
            int mostCommonCount = 0;
            for (int i = 0; i <= 5; i++)
            {
                int count = 0;
                for (int j = 0; j < ar.Length; j++)
                {                    
                    if (i == ar[j])
                    {
                        count++;
                    }                  
                }
                if (count > mostCommonCount)
                {
                    mostCommonCount = count;
                    mostCommonId = i;
                }
                else if (count == mostCommonCount && i != mostCommonId)
                {
                    if (ar[i] < mostCommonId)
                    {
                        mostCommonId = i;
                    }
                }
            }
            return mostCommonId;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = migratoryBirds(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
