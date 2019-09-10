using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TareaSurf_a_Thon.Classes;

namespace TareaSurf_a_Thon
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreChecker sc = new ScoreChecker();
            sc.CheckScore();
            Console.ReadKey();
        }
    }
}
