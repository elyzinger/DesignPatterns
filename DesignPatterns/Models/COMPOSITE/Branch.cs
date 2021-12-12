using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.COMPOSITE
{
    class Branch : LeafComponent
    {
        List<LeafComponent> leafTree = new List<LeafComponent>();

        public string BranchName { get; set; }
        public Branch(string branchName)
        {
            BranchName = branchName;
        }
        public override void Add(LeafComponent newLeaf)
        {
            leafTree.Add(newLeaf);
        }

        public override void Remove(LeafComponent newLeaf)
        {
            leafTree.Remove(newLeaf);
        }

        public override LeafComponent GetLeaf(int leafIndex)
        {

            return leafTree[leafIndex];

        }

        public override void DisplayLeaf()
        {
            Console.WriteLine($"Showing Branch `{BranchName}`\n");
            foreach(LeafComponent leaf in leafTree)
            {
                leaf.DisplayLeaf();
            }
        }
    }
}
