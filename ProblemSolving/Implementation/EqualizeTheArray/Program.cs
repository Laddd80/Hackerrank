using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualizeArray
{
    class Program
    {
        static int equalizeArray(int[] arr)
        {
            List<Elem> elemek = new List<Elem>();
            List<int> szamok = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!szamok.Contains(arr[i]))
                {
                    szamok.Add(arr[i]);
                    elemek.Add(new Elem(arr[i], 1));
                }
                else
                {
                    foreach (Elem item in elemek)
                    {
                        if (item.Index == arr[i])
                        {
                            item.Db++;
                        }
                    }
                }
            }

            int max = 0;
            foreach (Elem item in elemek)
            {
                if (item.Db > max)
                {
                    max = item.Db;
                }
            }

            return arr.Length - max;
        }

        class Elem
        {
            private int index ;
            public int Index
            {
                get { return index; }
                set { index = value; }
            }

            private int db;
            public int Db
            {
                get { return db; }
                set { db = value; }
            }

            public Elem(int index, int db)
            {
                Index = index;
                Db = db;
            }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = equalizeArray(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
