using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void extraLongFactorials(int n)
        {
            BigInteger x = 1;
            for (ulong i = 1; i <= Convert.ToUInt64(n); i++)
            {
                x *= i;
            }
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());

            extraLongFactorials(25);
        }
    }
}
