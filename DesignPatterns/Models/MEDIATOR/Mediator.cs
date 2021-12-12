using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.MEDIATOR
{
    interface Mediator
    {
        public void SaleOffer(string stock, int shares, int collCode);
        public void BuyOffer(string stock, int shares, int collCode);

        public void AddColleague(Colleague colleague);

    }
}
