using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaumAndBday
{
    class Program
    {
        static int taumBday(int b, int w, int bc, int wc, int z)
        {
            if (bc > wc + z)
            {
                return Convert.ToInt32((w + b) * wc + b * z);
            }
            else if (wc > bc + z)
            {
                return (w + b) * bc + w * z;
            }
            else
            {
                return b * bc + w * wc;
            }

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] bw = Console.ReadLine().Split(' ');

                int b = Convert.ToInt32(bw[0]);

                int w = Convert.ToInt32(bw[1]);

                string[] bcWcz = Console.ReadLine().Split(' ');

                int bc = Convert.ToInt32(bcWcz[0]);

                int wc = Convert.ToInt32(bcWcz[1]);

                int z = Convert.ToInt32(bcWcz[2]);

                int result = taumBday(b, w, bc, wc, z);

                Console.WriteLine(result);
            }

            //textWriter.Flush();
           // textWriter.Close();
        }
    }
}
