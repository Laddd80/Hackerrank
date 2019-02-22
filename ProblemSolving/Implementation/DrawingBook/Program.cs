using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DrawingBook
{
    class Program
    {
        static int pageCount(int n, int p)
        {
            int minPageTurn = 0;
            int onPage = 0;

            if (n%2 !=0)
            {
                n = n - 1;
            }

            if (n/2 >= p)
            {
                onPage = 1;
                while (onPage < p)
                {
                    minPageTurn++;
                    onPage += 2;
                }
            }
            else
            {
                onPage = n;
                while (onPage > p)
                {
                    minPageTurn++;
                    onPage -= 2;
                }
            }
            return minPageTurn;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
