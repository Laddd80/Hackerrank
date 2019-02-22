using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutTheSticks
{
    class Program
    {
        static int[] cutTheSticks(int[] arr)
        {
            List<int> sticksCut = new List<int>();
            List<int> tomb = arr.ToList();
            int sum = 1;

            while (sum > 0)
            {
                int shortest = tomb.Min();
                int cut = 0;
                for (int i = 0; i < tomb.Count; i++)
                {
                    if (tomb[i]<= 0)
                    {
                        tomb[i] = 0;
                    }
                    else
                    {
                        tomb[i] = tomb[i] - shortest;
                        cut++;
                    }
                }
                if (cut > 0)
                {
                    sticksCut.Add(cut);
                }

                tomb.RemoveAll(item => item == 0);

            }
            int[] result = sticksCut.ToArray();
            return result;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = cutTheSticks(arr);

            Console.WriteLine(string.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
