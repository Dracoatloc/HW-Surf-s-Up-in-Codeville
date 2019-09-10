using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaSurf_a_Thon.Classes;
using System.IO;

namespace TareaSurf_a_Thon.Classes
{
    class ScoreChecker
    {
        //Marco Antonio Torres Escárcega
        //A01568181

        public string[] archive1;
        public List<float> score = new List<float>();
        public Dictionary<float, string> SList = new Dictionary<float, string>();
        public ScoreChecker()
        {
            try
            {
                archive1 = File.ReadAllLines(@"C:\Users\mtorr\source\repos\TareaSurf-a-Thon\results.txt");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("Directory of the file is not correct; please verify that the directory is not \\mtorr\\source, since that is my own."); Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public void CheckScore()
        {
            int j = 0;

            for (int i = 0; i < archive1.Count(); i++)
            {
                string t = "";
                float z = 0;
                string n = "";
                foreach (char c in archive1[i])
                {
                    

                    if(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c=='.')
                    {
                        t = t + c;
                    }
                    else
                    {  
                        n = n + c;
                    }
                }
                z = float.Parse(t);

                score.Add(z);

                if(z == 0)
                {
                    continue;
                }
                else
                {
                    SList.Add(z, n);
                }
                j++;
            }

            float temp = 0;

            for (int i = 0; i < score.Count(); i++)
            {
                for (j = 0; j < score.Count() - 1; j++)
                {
                    if (score[j] < score[j + 1])
                    {
                        continue;
                    }
                    else if (score[j] > score[j + 1])
                    {
                        temp = score[j];
                        score[j] = score[j + 1];
                        score[j + 1] = temp;
                    }
                }
            }
                
            Console.WriteLine(SList[score[score.Count() - 1]] + score[score.Count() - 1]);
            Console.WriteLine(SList[score[score.Count() - 2]] + score[score.Count() - 2]);
            Console.WriteLine(SList[score[score.Count() - 3]] + score[score.Count() - 3]);

            Console.ReadKey();
        }
    }
}
