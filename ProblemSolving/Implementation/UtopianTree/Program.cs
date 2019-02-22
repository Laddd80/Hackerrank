using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class Program
    {
        static int utopianTree(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n==1)
            {
                return n * 2;
            }
            else
            {
                int height = 1;
                for (int i = 1; i <= n; i++)
                {
                    if (i%2 != 0)
                    {
                        height = height * 2;
                    }
                    else
                    {
                        height++;
                    }
                }
                return height;
            }
        }

        static void Main(string[] args)
        {
            /*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
            */
        }
    }
