using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFine
{
    class Program
    {
        static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            if (y1<y2)
            {
                return 0;
            }
            else if (y1 == y2)
            {
                if (m1 < m2)
                {
                    return 0;                   
                }
                else if (m1 == m2)
                {
                    if (d1 <= d2)
                    {
                        return 0;
                    }
                    else
                    {
                        return (d1 - d2) * 15;
                    }
                }
                else
                {
                    return (m1 - m2) * 500;
                }
            }
            else
            {
                return 10000;
            }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] d1M1Y1 = Console.ReadLine().Split(' ');

            int d1 = Convert.ToInt32(d1M1Y1[0]);

            int m1 = Convert.ToInt32(d1M1Y1[1]);

            int y1 = Convert.ToInt32(d1M1Y1[2]);

            string[] d2M2Y2 = Console.ReadLine().Split(' ');

            int d2 = Convert.ToInt32(d2M2Y2[0]);

            int m2 = Convert.ToInt32(d2M2Y2[1]);

            int y2 = Convert.ToInt32(d2M2Y2[2]);

            int result = libraryFine(d1, m1, y1, d2, m2, y2);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
