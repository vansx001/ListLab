using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballList
{
    class BaseballList
    {
        List<string> baseballStatsName = new List<string>() { "Games", "At Bats", "Runs", "Hits", "Total Bases", "Doubles", "Triples" };
        List<string> baseballStats = new List<string>() { "111", "383", "54", "83", "184", "21", "1" };

        public void RunBaseballStat()
        {
            Console.WriteLine("Milwaukee Brewers - Chris Carter - #33 Baseball Stats\n");
            for (int i = 0; i < baseballStatsName.Count; i++)
            {

                Console.WriteLine(baseballStatsName[i] + ": " + baseballStats[i]);
            }
                Console.ReadLine();
        }
    }
}
