using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.DECORATOR
{
    class PlainPizza : Pizza
    {
        public PlainPizza()
        {
            Console.WriteLine("Making Plain Pizza");
        }
        public double GetCost()
        {
            return 10;
        }

        public string GetDescription()
        {
            return "Plane Pizza";
        }
    }
}
