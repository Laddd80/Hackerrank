using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyLadybugs
{
    class Program
    {
        static string happyLadybugs(string b)
        {
            if (!BiggerThanOne(b))
            {
                return "NO";
            }
            else
            {
                if (BugCount('_', b) >= 1)
                {
                    return "YES";
                }
                else
                {
                    if (NetToEachOther(b))
                    {
                        return "YES";
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }         
        }

        public static bool BiggerThanOne(string s)
        {
            string abc = GetABC(s);

            for (int i = 0; i < abc.Length; i++)
            {
                int szamol = BugCount(abc[i], s);
                if (szamol == 1)
                {
                    return false;
                }
            }
            return true;
        }

        public static string GetABC(string s)
        {
            s = s.Replace('_', ' ');
            s = s.Trim();
            var sb = new StringBuilder();
            var rendezett = (from x in s
                             orderby x
                             select x).Distinct();

            foreach (var c in rendezett)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }

        public static int BugCount(char c, string s)
        {
            int charCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    charCount++;
                }
            }
            return charCount;
        }

        public static bool NetToEachOther(string s)
        {
            bool result = true;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (i == 0)
                {
                    if (s[i] != s[i+1])
                    {
                        result = false;
                    }
                }
                else
                {
                    if (s[i] != s[i+1] && s[i] != s[i-1])
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int g = Convert.ToInt32(Console.ReadLine());

            for (int gItr = 0; gItr < g; gItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string b = Console.ReadLine();

                string result = happyLadybugs(b);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
