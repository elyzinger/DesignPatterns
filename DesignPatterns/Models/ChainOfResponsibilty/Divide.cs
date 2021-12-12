using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.ChainOfResponsibilty
{
    class Divide : Chain
    {
        private Chain nextInChain;

        public void Calculation(NumbersCulc request)
        {
            if (request.CalcOption == "div")
            {
                Console.WriteLine($"{request.Number1} / {request.Number2} = {request.Number1 / request.Number2}");
            }
            else
            {
                Console.WriteLine($"No Option For {request.CalcOption}! Only 4 Options add/sub/mult/div");
            }
        }

        public void SetNexthain(Chain nextChain)
        {
            nextInChain = nextChain;
        }
    }
}
