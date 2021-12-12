using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.MEDIATOR
{
    internal class FBB : Colleague
    {
        public FBB(Mediator newMediator) : base(newMediator) // sending the new mediator to paraent
        {
            Console.WriteLine("FBB SIGN UP FOR STOCK EXCHANGE!");
        }
    }
}
