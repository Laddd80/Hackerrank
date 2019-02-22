using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            int position = 0;

            while (position != c.Length-1)
            {
                if (position+2 < c.Length)
                {
                    if (c[position + 2] != 1)
                    {
                        position += 2;
                    }
                    else
                    {
                        position++;
                    }
                }
                else
                {
                    position++;
                }

                jumps++;
            }

            return jumps;           
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
