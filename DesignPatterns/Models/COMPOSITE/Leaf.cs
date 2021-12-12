using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.COMPOSITE
{
    class Leaf : LeafComponent
    {
        public string LeafName { get; set; }

        public Leaf(string leafName)
        {
            LeafName = leafName;
        }
        public override void Add(LeafComponent newLeaf)
        {
            throw new NotImplementedException();
        }

        public override LeafComponent GetLeaf(int leafIndex)
        {
            throw new NotImplementedException();
        }

        public override void Remove(LeafComponent newLeaf)
        {
            throw new NotImplementedException();
        }

        public override void DisplayLeaf()
        {
            Console.WriteLine($"Leaf Name Is {LeafName}");
        }
    }
}
