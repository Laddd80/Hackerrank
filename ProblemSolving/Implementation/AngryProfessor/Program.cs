using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryProfessor
{
    class Program
    {
        static string angryProfessor(int k, int[] a)
        {
            int onTime = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <=0)
                {
                    onTime++;
                }
            }
            if (onTime < k)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        static void Main(string[] args)
        {
            /*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
                string result = angryProfessor(k, a);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
