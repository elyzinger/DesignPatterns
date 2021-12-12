using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.PROTOTYPE
{
    static class AnimalCloneFactory
    {
        public static Beast CloneAnimal(Beast beast)
        {
            return beast.MakeCopy();
        }
    }
}
