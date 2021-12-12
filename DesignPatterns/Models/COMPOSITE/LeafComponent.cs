using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.COMPOSITE
{
   abstract class LeafComponent
    {
        public abstract void Add(LeafComponent newLeaf);

        public abstract void Remove(LeafComponent newLeaf);

        public abstract LeafComponent GetLeaf(int leafIndex);

        public abstract void DisplayLeaf();
    }
}
