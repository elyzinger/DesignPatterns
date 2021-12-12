using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.MEDIATOR
{
    class StockOffer
    {
        public int StockShares { get; set; }
        public string StockSymble { get; set; }

        public int ColleagueCode { get; set; }

        public StockOffer(int stockShares, string stockSymble, int colleagueCode)
        {
            StockShares = stockShares;
            StockSymble = stockSymble;
            ColleagueCode = colleagueCode;

        }

    }
}
