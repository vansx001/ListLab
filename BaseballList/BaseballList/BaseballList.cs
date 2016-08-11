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
            var statsNameAndStats = baseballStatsName.Zip(baseballStats, (first, second) => first + ": " + second);
            foreach (var item in statsNameAndStats)

            Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
