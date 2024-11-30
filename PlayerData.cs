using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCardAssign
{
    internal class PlayerData
    {
        public static List<TradingCard> tradingCards = new List<TradingCard>
        {
            new TradingCard { PlayerName = "LeBron James", Team = "Lakers", ImagePath = "lebron_james", PointsPerGame = 25, ReboundsPerGame = 8, AssistsPerGame = 7, StealsPerGame = 1 },
            new TradingCard { PlayerName = "Anthony Davis", Team = "Lakers", ImagePath = "anthony_davis", PointsPerGame = 22, ReboundsPerGame = 10, AssistsPerGame = 3, StealsPerGame = 2 },
            new TradingCard { PlayerName = "Stephen Curry", Team = "Warriors", ImagePath = "stephen_curry", PointsPerGame = 30, ReboundsPerGame = 5, AssistsPerGame = 6, StealsPerGame = 2 },
            new TradingCard { PlayerName = "Klay Thompson", Team = "Warriors", ImagePath = "klay-thompson", PointsPerGame = 20, ReboundsPerGame = 4, AssistsPerGame = 3, StealsPerGame = 1 },
            new TradingCard { PlayerName = "Kevin Durant", Team = "Suns", ImagePath = "kevin_durant", PointsPerGame = 29, ReboundsPerGame = 7, AssistsPerGame = 5, StealsPerGame = 1 },
            new TradingCard { PlayerName = "Devin Booker", Team = "Suns", ImagePath = "devin_booker", PointsPerGame = 27, ReboundsPerGame = 4, AssistsPerGame = 6, StealsPerGame = 1 },
            new TradingCard { PlayerName = "Jayson Tatum", Team = "Celtics", ImagePath = "jayson_tatum", PointsPerGame = 28, ReboundsPerGame = 8, AssistsPerGame = 4, StealsPerGame = 1 },
            new TradingCard { PlayerName = "Jaylen Brown", Team = "Celtics", ImagePath = "Jaylen_Brown", PointsPerGame = 25, ReboundsPerGame = 6, AssistsPerGame = 3, StealsPerGame = 1 },
            new TradingCard { PlayerName = "Giannis Antetokounmpo", Team = "Bucks", ImagePath = "giannis_antetokounmpo", PointsPerGame = 31, ReboundsPerGame = 11, AssistsPerGame = 6, StealsPerGame = 1 },
            new TradingCard { PlayerName = "Damian Lillard", Team = "Bucks", ImagePath = "damian_lillard", PointsPerGame = 32, ReboundsPerGame = 4, AssistsPerGame = 7, StealsPerGame = 1 }
        };

    }
}
