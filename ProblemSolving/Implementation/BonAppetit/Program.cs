using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int arCount = Convert.ToInt32(Console.ReadLine());

            int[] arItems = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int[] arCosts = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int share = Convert.ToInt32(Console.ReadLine());
            int overCharge = 0;
            int sum = 0;

            for (int i = 0; i < arCosts.Length; i++)
            {
                sum += arCosts[i];
            }

            sum -= arCosts[arItems[1]];

            if (sum / 2 == share)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                sum = share - sum / 2;
                Console.WriteLine(sum);
            }

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
