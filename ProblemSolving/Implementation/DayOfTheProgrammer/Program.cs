using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DayOfTheProgrammer
{
    class Program
    {
        static string solve(int year)
        {
            if (year < 1918)
            {
                if (year %4 == 0)
                {
                    return "12.09." + year;
                }
                else
                {
                    return "13.09." + year;
                }
            }
            else if (year == 1918)
            {
                return "26.09.1918";
            }
            else
            {
                if ((year %400 == 0)||(year %4 ==0 && year %100 != 0))
                {
                    return "12.09." + year;
                }
                else
                {
                    return "13.09." + year;
                }
            }

        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int year = Convert.ToInt32(Console.ReadLine());

            string result = solve(year);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
