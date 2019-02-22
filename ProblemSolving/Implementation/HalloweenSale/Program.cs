using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenSale
{
    class Program
    {
        static int howManyGames(int p, int d, int m, int s)
        {
            // Return the number of games you can buy
            int count = 0;

            while(s >= m && s >=p)
            {
                s -= p;

                if (p - d > m)
                {
                    p -= d;
                }
                else
                {
                    p = m;
                }
                count++;
               
            }
            return count;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] pdms = Console.ReadLine().Split(' ');

            int p = Convert.ToInt32(pdms[0]);

            int d = Convert.ToInt32(pdms[1]);

            int m = Convert.ToInt32(pdms[2]);

            int s = Convert.ToInt32(pdms[3]);

            int answer = howManyGames(p, d, m, s);

            textWriter.WriteLine(answer);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
