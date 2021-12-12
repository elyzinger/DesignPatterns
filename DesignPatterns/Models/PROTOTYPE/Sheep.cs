using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.PROTOTYPE
{
    class Sheep : Beast
    {
        public string Name { get; set; }
        
        public Sheep(string name)
        {
            Name = name;
            Console.WriteLine("sheep was mad");
        }
        public object Clone()
        {
            Sheep copySheep = new Sheep(this.Name);
            return copySheep;
        }

        public Beast MakeCopy()
        {
            Console.WriteLine($"Sheep: {Name}, was cloned");

            return (Sheep)Clone();
        }
    }
}
