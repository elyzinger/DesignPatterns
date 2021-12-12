using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.PROTOTYPE
{
    interface Beast : ICloneable
    {

        public abstract Beast MakeCopy();
    }
}
