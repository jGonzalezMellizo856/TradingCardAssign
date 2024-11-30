using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCardAssign
{
    internal class TradingCardData : PlayerData
    {
        public static List<TradingCard> GetTradingCards()
        {
            return tradingCards;
        }
    }
}
