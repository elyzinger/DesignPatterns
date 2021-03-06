using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.ChainOfResponsibilty
{
    class Multiply : Chain
    {
        private Chain nextInChain;

        public void Calculation(NumbersCulc request)
        {
            if (request.CalcOption == "mult")
            {
                Console.WriteLine($"{request.Number1} * {request.Number2} = {request.Number1 * request.Number2}");
            }
            else
            {
                nextInChain.Calculation(request);
            }
        }

        public void SetNexthain(Chain nextChain)
        {
            nextInChain = nextChain;
        }
    }
}
