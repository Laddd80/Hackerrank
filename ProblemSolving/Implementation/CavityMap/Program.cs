using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavityMap
{
    class Program
    {
        static string[] cavityMap(string[] grid)
        {
            int oszlop = grid[0].Length;
            int sor = grid.Length;

            for (int i = 1; i < sor-1; i++)
            {
                for (int j = 1; j < oszlop-1; j++)
                {
                    int center = Convert.ToInt32(grid[i][j]);
                    int up = Convert.ToInt32(grid[i-1][j]);
                    int down = Convert.ToInt32(grid[i+1][j]);
                    int left = Convert.ToInt32(grid[i][j-1]);
                    int right = Convert.ToInt32(grid[i][j+1]);

                    if (center > up && center > down && center > left && center > right)
                    {
                        grid[i] = ReplaceAtIndex(j, 'X', grid[i]);
                    }
                }
            }
            return grid;
        }
        static string ReplaceAtIndex(int i, char value, string word)
        {
            char[] letters = word.ToCharArray();
            letters[i] = value;
            return string.Join("", letters);
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string[] grid = new string[n];

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid[i] = gridItem;
            }

            string[] result = cavityMap(grid);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
