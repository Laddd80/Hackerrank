using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BreakingTheRecords
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {
            int[] breaking = new int[2];

            int min = scores[0];
            int max = scores[0];

            int breakMin = 0;
            int breakMax = 0;

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                    breakMin++;
                }
                else if (scores[i] > max)
                {
                    max = scores[i];
                    breakMax++;
                }
            }
            breaking[0] = breakMax;
            breaking[1] = breakMin;

            return breaking;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int[] result = breakingRecords(scores);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
