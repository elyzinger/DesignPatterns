using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.MEDIATOR
{
   abstract class Colleague
    {
        private Mediator mediator;
        private int colleagueCode;
        public int ColleagueCode
        {   
            get
            {
                return colleagueCode;
            }
            set 
            {
                colleagueCode = value;
            } 
        }

        public Colleague(Mediator newMediator)
        {
            mediator = newMediator;
            mediator.AddColleague(this);
        }

        public void SaleOffer(string stock, int shares)
        {
            mediator.SaleOffer(stock, shares, colleagueCode);
        }
        public void BuyOffer(string stock, int shares)
        {
            mediator.BuyOffer(stock, shares, colleagueCode);
        }
    }
}
