using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingMedium
{
    class Program
    {
        static string encryption(string s)
        {
            s = s.Trim();

            int length = s.Length;

            int floor = (int)Math.Floor(Math.Sqrt(length));
            int ceil = (int)Math.Ceiling(Math.Sqrt(length));

            if (floor * ceil < length)
            {
                floor=ceil;
            }

            string[,] stringMatrix = new string[floor, ceil];

            int idx = 0;

            for (int i = 0; i < floor; i++)
            {
                for (int j = 0; j < ceil; j++)
                {
                    try
                    {
                        stringMatrix[i, j] = s[idx].ToString();
                        idx++;
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            string encoded = "";

            for (int j = 0; j < ceil; j++)
            {
                for (int i = 0; i < floor; i++)
                {
                    try
                    {
                        encoded = encoded + (stringMatrix[i, j]);
                    }
                    catch (Exception)
                    {

                    }
                }
                encoded = encoded + " ";
            }

            return encoded;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = encryption(s);

            
            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
