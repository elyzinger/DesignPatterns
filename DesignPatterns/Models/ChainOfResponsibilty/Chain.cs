using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.ChainOfResponsibilty
{
    interface Chain
    {
        public void SetNexthain(Chain nextChain);

        public void Calculation(NumbersCulc request);
    }
}
