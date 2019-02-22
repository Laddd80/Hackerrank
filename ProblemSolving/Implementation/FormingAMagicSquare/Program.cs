using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormingMagicSquare
{
    class Program
    {
        static int formingMagicSquare(int[][] s)
        {
            int[,] square1 = new int[3,3]{ { 8, 1, 6 },
                                            { 3, 5, 7 },
                                            { 4, 9, 2 }};

            int[,] square2 = new int[3, 3]{ { 6, 1, 8 },
                                            { 7, 5, 3 },
                                            { 2, 9, 4 }};

            int[,] square3 = new int[3, 3]{ { 4, 3, 8 },
                                            { 9, 5, 1 },
                                            { 2, 7, 6 }};

            int[,] square4 = new int[3, 3]{ { 8, 3, 4 },
                                            { 1, 5, 9 },
                                            { 6, 7, 2 }};

            int[,] square5 = new int[3, 3]{ { 4, 9, 2 },
                                            { 3, 5, 7 },
                                            { 8, 1, 6 }};

            int[,] square6 = new int[3, 3]{ { 2, 9, 4 },
                                            { 7, 5, 3 },
                                            { 6, 1, 8 }};

            int[,] square7 = new int[3, 3]{ { 2, 7, 6 },
                                            { 9, 5, 1 },
                                            { 4, 3, 8 }};

            int[,] square8 = new int[3, 3]{ { 6, 7, 2 },
                                            { 1, 5, 9 },
                                            { 8, 3, 4 }};


            int sumMin = 0;
            sumMin = SumChange(s, square1);

            if (sumMin > SumChange(s, square2))
            {
                sumMin = SumChange(s, square2);
            }
            if (sumMin > SumChange(s, square3))
            {
                sumMin = SumChange(s, square3);
            }
            if (sumMin > SumChange(s, square4))
            {
                sumMin = SumChange(s, square4);
            }
            if (sumMin > SumChange(s, square5))
            {
                sumMin = SumChange(s, square5);
            }
            if (sumMin > SumChange(s, square6))
            {
                sumMin = SumChange(s, square6);
            }
            if (sumMin > SumChange(s, square7))
            {
                sumMin = SumChange(s, square7);
            }
            if (sumMin > SumChange(s, square8))
            {
                sumMin = SumChange(s, square8);
            }
            return sumMin;

        }
        
        static int SumChange(int[][] s, int[,] sq)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += Math.Abs(s[i][j] - sq[i, j]);
                }
            }
            return sum;
        }

        /*
        static bool isMagicSquare(int[][] s)
        {
            int countAll = 0;
            bool isEqual = true;
            for (int i = 0; i < 3; i++)
            {
                int countRow = 0;
                for (int j = 0; j < 3; j++)
                {
                    countAll += s[i][j];
                    countRow += s[i][j];
                }
                if (countRow != 15)
                {
                    isEqual = false;
                }
            }

            int diagonal = 0;
            for (int i = 0; i < 3; i++)
            {
                diagonal += s[i][i];
            }
            if (diagonal !=15)
            {
                isEqual = false;
            }

            diagonal = 0;
            for (int i = 0; i < 3; i++)
            {
                diagonal += s[i][3 - i];
            }
            if (diagonal != 15)
            {
                isEqual = false;
            }

            for (int i = 0; i < 3; i++)
            {
                int countCol = 0;
                for (int j = 0; j < 3; j++)
                {
                    countCol += s[j][i];
                }
                if (countCol != 15)
                {
                    isEqual = false;
                }
            }
            if (countAll != 45)
            {
                isEqual = false;
            }
            return isEqual;
        }
        */
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] s = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }

            int result = formingMagicSquare(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
