using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPDFViewer
{
    class Program
    {
        static int designerPdfViewer(int[] h, string word)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            int highest = 0;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (word[i] == abc[j])
                    {
                        if (h[j] > highest)
                        {
                            highest = h[j];
                        }
                    }
                }
            }
            return highest * word.Length;

        }
        static void Main(string[] args)
        {
            /*
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
            */
        }
    }
    }
}
