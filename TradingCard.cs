using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCardAssign
{
    internal class TradingCard
    {
        public string PlayerName { get; set; }
        public string Team {  get; set; }
        public string ImagePath { get; set; }
        public int PointsPerGame { get; set; }
        public int ReboundsPerGame { get; set; }
        public int AssistsPerGame { get; set; }
        public int StealsPerGame { get; set; }

    }

   
}
