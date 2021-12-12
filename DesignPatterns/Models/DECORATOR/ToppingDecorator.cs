using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.DECORATOR
{
    class ToppingDecorator : Pizza
    {
        public Pizza Pizza { get; set; }
        public ToppingDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }
        public virtual double GetCost()
        {
          return Pizza.GetCost();   
        }

        public virtual string GetDescription()
        {
          return Pizza.GetDescription();
        }
    }
}
