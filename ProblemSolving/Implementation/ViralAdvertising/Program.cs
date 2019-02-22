using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViralAdvertising
{
    class Program
    {
        static int viralAdvertising(int n)
        {
            int receives =0;
            int likes =0;
            int likeSum = 0;
            for (int i = 1; i <=n; i++)
            {
                if (i==1)
                {
                    receives = 5;
                    likes = receives / 2;
                }
                else
                {
                    receives = likes * 3;
                    likes = receives / 2;
                }

                likeSum += likes;
                
            }
            return likeSum;
        }

        static void Main(string[] args)
        {
            /*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
            */
        }
    }
}
