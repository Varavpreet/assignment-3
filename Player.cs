using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketTradingCards
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string PhotoPath { get; set; }
        public int Runs { get; set; }
        public int Wickets { get; set; }
        public int Matches { get; set; }
        public double Average { get; set; }
    }

}
