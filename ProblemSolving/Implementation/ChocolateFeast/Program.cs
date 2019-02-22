using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class Program
    {
        static int chocolateFeast(int n, int c, int m)
        {
            int wrappers = 0;
            int eating = 0;

            while (n>=c || wrappers >= m)
            {
                if (wrappers <m && n>=c)
                {
                    wrappers++;
                    eating++;
                    n = n - c;
                }
                else if (wrappers >= m)
                {
                    wrappers = wrappers - m;
                    wrappers++;
                    eating++;
                }
            }
            return eating;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] ncm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(ncm[0]);

                int c = Convert.ToInt32(ncm[1]);

                int m = Convert.ToInt32(ncm[2]);

                int result = chocolateFeast(n, c, m);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
