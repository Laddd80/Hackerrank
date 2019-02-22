using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatsAndAMosue
{
    class Program
    {
        static string catAndMouse(int x, int y, int z)
        {
            while (x != z || y != z)
            {
                if (z > x)
                {
                    x++;
                }
                else if (z<x)
                {
                    x--;
                }

                if (z > y)
                {
                    y++;
                }
                else if (z < y)
                {
                    y--;
                }              
            }
            if (x == z && y == z)
            {
                return "Mouse C";
            }
            else if (x== z)
            {
                return "Cat A";
            }
            else
            {
                return "Cat B";
            }

        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                //textWriter.WriteLine(result);
                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
