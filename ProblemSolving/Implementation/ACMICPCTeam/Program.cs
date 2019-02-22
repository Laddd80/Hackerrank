using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMteam
{
    class Program
    {
        static int[] acmTeam(string[] topic)
        {
            int maxTopics = 0;
            int teams = 0;

            for (int i = 0; i < topic.Length-1; i++)
            {
                for (int j = i+1; j < topic.Length; j++)
                {
                    int c = ComboCount(topic[i], topic[j]);
                    if (c > maxTopics)
                    {
                        maxTopics = c;
                        teams = 1;
                    }
                    else if (c == maxTopics)
                    {
                        teams++;
                    }
                }
            }
            return new int[]{maxTopics,teams};          
        }

        static int ComboCount(string elso, string masodik)
        {
            int count = 0;
            for (int i = 0; i < elso.Length; i++)
            {
                if (elso[i] == '1' || masodik[i]=='1')
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            string[] topic = new string[n];

            for (int i = 0; i < n; i++)
            {
                string topicItem = Console.ReadLine();
                topic[i] = topicItem;
            }

            int[] result = acmTeam(topic);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
