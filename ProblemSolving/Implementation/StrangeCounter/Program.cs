using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeCounter
{
    class Program
    {
        static long strangeCounter(long t)
        {
            long countdown = 3;

            while(t > countdown)
            {
                t -= countdown;
                countdown *= 2;
            }

            if (t <= countdown)
            {
                return countdown + 1 - t;
            }else
            {
                return 0;
            }

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            long t = Convert.ToInt64(Console.ReadLine());

            long result = strangeCounter(t);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
