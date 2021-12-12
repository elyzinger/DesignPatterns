﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.DECORATOR
{
    class OnionTopping : ToppingDecorator
    {
        public OnionTopping(Pizza pizz) : base(pizz)
        {
            Console.WriteLine("Adding Onion");
        }
        public override double GetCost()
        {
            return Pizza.GetCost() + 0.5;
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + " + Onion";
        }
    }
}
