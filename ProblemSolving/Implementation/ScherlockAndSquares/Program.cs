using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockSquares
{
    class Program
    {
        static int squares(int a, int b)
        {
            int sqres = 0;
            List<int> sqrList = new List<int>();

            for (int i = 1; i <= Math.Sqrt(b); i++)
            {
                int x = i * i;
                if (x >= a && x<=b)
                {
                    sqrList.Add(i * i);
                }
            }

            sqres = sqrList.Count;

            return sqres;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = squares(a, b);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
