using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendDelete
{
    class Program
    {
        static string appendAndDelete(string s, string t, int k)
        {
            int sLength = s.Length;
            int tLength = t.Length;

            int rovidebb = (sLength < t.Length) ? sLength : tLength;

            int idx = 0;
            for (int i = 0; i < rovidebb; i++)
            {
                if (s[i] == t[i])
                {
                    idx++;
                }
                else
                {
                    break;
                }
            }
            if ((sLength - idx) + (tLength-idx) == k)
            {
                return "Yes";
            }
            else if (tLength + tLength < k)
            {
                return "Yes";
            }
            else if ((sLength - idx) + (tLength - idx) > k)
            {
                return "No";
            }
            else if (((sLength - idx) + (tLength - idx)-k)%2 == 0)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        static void Main(string[] args)
        {
            /*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = appendAndDelete(s, t, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
