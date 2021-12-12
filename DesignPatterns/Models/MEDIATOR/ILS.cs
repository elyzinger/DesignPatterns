using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.MEDIATOR
{
    class ILS : Colleague
    {
        public ILS(Mediator newMediator) : base(newMediator)
        {
            Console.WriteLine("ILS SIGN UP FOR STOCK EXCHANGE!");
        }
    }
}
