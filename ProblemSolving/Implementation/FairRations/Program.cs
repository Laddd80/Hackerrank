using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairRations
{
    class Program
    {
        static int fairRations(int[] B)
        {
            int sum = 0;
            bool even = true;
            int count = 0;
            for (int i = 0; i < B.Length; i++)
            {
                sum += B[i];
                if (B[i] % 2 != 0)
                {
                    even = false;
                }
            }
            if (sum % 2 !=0)
            {
                return -1;
            }

            if (!even)
            {
                for (int i = 0; i < B.Length; i++)
                {
                    if(B[i]%2 == 1)
                    {
                        if (i == 0)
                        {
                            B[i]++;
                            B[i + 1]++;
                            count+=2;
                        }
                        else if (i== B.Length - 1)
                        {
                            B[i]--;
                            B[i - 1]--;
                            count += 2;
                        }
                        else
                        {
                            if (B[i-1] %2 ==1)
                            {
                                B[i]++;
                                B[i - 1]++;
                                count += 2;
                            }
                            else
                            {
                                B[i]++;
                                B[i + 1]++;
                                count += 2;
                            }
                        }
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int N = Convert.ToInt32(Console.ReadLine());

            int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp))
            ;
            int result = fairRations(B);

            if (result != -1)
            {
                textWriter.WriteLine(result);
            }
            else
            {
                textWriter.WriteLine("NO");
            }
            

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
