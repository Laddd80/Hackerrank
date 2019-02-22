using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ModifiedKaperNrs
{
    class Program
    {
        static void kaprekarNumbers(int p, int q)
        {
            bool talalat = false;

            for (BigInteger i = p; i <= q; i++)
            {
                BigInteger negyzet = new BigInteger();
                negyzet = i * i;
                string number = negyzet.ToString();
                int d = number.Length;

                long right = 0;
                long left = 0;

                if (d % 2 == 0)
                {
                    string strLeft = "";
                    string strRight = number.Substring(d - d / 2);
                    right = Convert.ToInt64(strRight);

                    if (d - strRight.Length > 0)
                    {
                        strLeft = number.Substring(0,d-d/2);
                        left = Convert.ToInt32(strLeft);
                    }
                }
                else
                {
                    string strLeft = "";
                    string strRight = number.Substring(d - (d/2)-1);
                    right = Convert.ToInt64(strRight);

                    if (d - strRight.Length > 0)
                    {
                        strLeft = number.Substring(0, d - (d / 2) - 1);
                        left = Convert.ToInt32(strLeft);
                    }
                }


                if (left+right == i)
                {
                    Console.Write(i + " ");
                    talalat = true;
                }
            }

            if (!talalat)
            {
                Console.Write("INVALID RANGE");
            }
        }

        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());

            int q = Convert.ToInt32(Console.ReadLine());

            kaprekarNumbers(p, q);
        }
    }
}
