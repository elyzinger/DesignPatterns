using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.ChainOfResponsibilty
{
    class Subtract : Chain
    {
        private Chain nextInChain;

        public void Calculation(NumbersCulc request)
        {
            if (request.CalcOption == "sub")
            {
                Console.WriteLine($"{request.Number1} - {request.Number2} = {request.Number1 - request.Number2}");
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
