using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.PROTOTYPE
{
    class Wolf : Beast
    {
        public string Name { get; set; }

        public Wolf(string name)
        {
            Name = name;
            Console.WriteLine("sheep was mad");
        }
        public object Clone()
        {
            Wolf copyWolf = new Wolf(this.Name);
            return copyWolf;
        }

        public Beast MakeCopy()
        {
            Console.WriteLine($"Wolf: {Name}, was cloned");

            return (Wolf)Clone();
        }
    }
}
