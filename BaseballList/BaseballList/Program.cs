using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballList
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseballList baseballList = new BaseballList();
            Console.WriteLine("Milwaukee Brewers - Chris Carter - #33 Baseball Stats\n");
            baseballList.RunBaseballStat();
        }
    }
}
