using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrisoner
{
    class Program
    {
        static int saveThePrisoner(int n, int m, int s)
        {
            int rest = n - s + 1;

            if (m > rest)
            {
                s = 1;
                m -= rest;
                m %= n;
            }

            if (m == 0)
            {
                return n;
            }
            else
            {
                s += m - 1;
                return s;
            }
        }

        static void Main(string[] args)
        {
            /*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nms = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nms[0]);

                int m = Convert.ToInt32(nms[1]);

                int s = Convert.ToInt32(nms[2]);

                int result = saveThePrisoner(n, m, s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
