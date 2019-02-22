using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingStrings
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
            int count = 0;
            int hossz = s.Length;

            for (int i = 0; i < hossz; i++)
            {
                if (s[i] == 'a')
                {
                    count++;
                }
            }

            long hanyszor = n / hossz;
            long maradek = n % hossz;

            int marCount = 0;

            for (int i = 0; i < maradek; i++)
            {
                if (s[i] == 'a')
                {
                    marCount++;
                }
            }

            return hanyszor * count + marCount;

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
