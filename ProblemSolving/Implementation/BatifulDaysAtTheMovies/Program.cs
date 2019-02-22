using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautDaysMovies
{
    class Program
    {
        static int beautifulDays(int i, int j, int k)
        {
            int bDays = 0;
            for (int l = i; l <= j; l++)
            {
                string xString = new string(l.ToString().Reverse().ToArray());
                int x = Convert.ToInt32(xString);

                if (Math.Abs(x-l)%k ==0)
                {
                    bDays++;
                }
            }
            return bDays;
        }

        static void Main(string[] args)
        {
            /*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
