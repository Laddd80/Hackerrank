using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        static int findDigits(int n)
        {
            string intString = Convert.ToString(n);

            int divisor = 0;

            foreach (char item in intString)
            {
                int x = Convert.ToInt32(item.ToString());

                if (x != 0)
                {
                    if (n % x == 0)
                    {
                        divisor++;
                    }
                }

            }

            return divisor;            
        }

        static void Main(string[] args)
        {/*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                textWriter.WriteLine(result);
            }           

            textWriter.Flush();
            textWriter.Close();*/

            Console.WriteLine(findDigits(114108089));
        }
    }
}
