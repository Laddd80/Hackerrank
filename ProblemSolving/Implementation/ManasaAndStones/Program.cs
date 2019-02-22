using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MansanaAndStones
{
    class Program
    {
        static int[] stones(int n, int a, int b)
        {
            List<int> numbers = new List<int>();

            int num;
            for (int i = 0; i < n; i++)
            {
                num = i * b + (n - 1 - i) * a;
                if (!numbers.Contains(num))
                {
                    numbers.Add(num);
                }
            }
            numbers.Sort();
            return numbers.ToArray();
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int T = Convert.ToInt32(Console.ReadLine());

            for (int TItr = 0; TItr < T; TItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int a = Convert.ToInt32(Console.ReadLine());

                int b = Convert.ToInt32(Console.ReadLine());

                int[] result = stones(n, a, b);

                textWriter.WriteLine(string.Join(" ", result));
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
