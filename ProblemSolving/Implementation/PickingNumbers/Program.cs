using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PickingNumbers
{
    class Program
    {
        static int pickingNumbers(int[] a)
        {
            //int lengthCount = 1;
            int maxLength = 0;
            int l = a.Length;

            for (int i = 0; i < l-1; i++)
            {
                List<int> szamok = new List<int>();
                szamok.Add(a[i]);
                for (int j = 0; j < l; j++)
                {
                    bool ok = true;
                    foreach (int item in szamok)
                    {
                        if (Math.Abs(item - a[j])>1)
                        {
                            ok = false;
                        }

                    }
                    if (ok && j != i)
                    {
                        szamok.Add(a[j]);
                    }
                }

                if (szamok.Count > maxLength)
                {
                    maxLength = szamok.Count;
                }

            }
            return maxLength;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int result = pickingNumbers(a);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
