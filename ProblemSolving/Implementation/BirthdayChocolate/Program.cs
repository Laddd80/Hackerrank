using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BirthdayChoc
{
    class Program
    {
        static int solve(int[] s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i <= s.Length-m; i++)
            {
                int sum = 0;

                for (int j = 0; j < m; j++)
                {
                    sum += s[i+j];
                }
                if (sum ==d)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp))
            ;
            string[] dm = Console.ReadLine().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = solve(s, d, m);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
