using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballList
{
    
    class BaseballList
    {
        List<string> statName;
        List<double> stats;

        public BaseballList()
        {
            statName = new List<string>() { "Games", "At Bats", "Runs", "Hits", "Total Bases", "Doubles", "Triples" };
            stats = new List<double>();
        }
        public void UserAddBaseballStat()
        {
            for (int i = 0; i < statName.Count; i++)
            {
                Console.WriteLine("Please enter stats for " + statName[i] + ":");
                stats.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }
        public void PrintList()
        {
            for (int i = 0; i < statName.Count; i++)
            {
                Console.WriteLine("\n" + statName[i] + ": " + stats[i]);
            }
            Console.ReadLine();
        }
    }
}
