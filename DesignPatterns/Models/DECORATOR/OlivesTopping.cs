using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.DECORATOR
{
    class OlivesTopping : ToppingDecorator
    {
        public OlivesTopping(Pizza pizz) : base(pizz)
        {
            Console.WriteLine("Adding Olives");
        }
        public override double GetCost()
        {
            return Pizza.GetCost() + 0.5;
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + " + Olives";
        }
    }
}
