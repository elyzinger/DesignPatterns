using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.DECORATOR
{
    class ExtraCheeseTopping : ToppingDecorator
    {
        public ExtraCheeseTopping(Pizza pizz) : base(pizz)
        {
            Console.WriteLine("Adding Extra Cheese");
        }
        public override double GetCost()
        {
            return Pizza.GetCost() + 1.5;
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + " + Extra Cheese";
        }
    }
}
