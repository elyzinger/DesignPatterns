using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Cat : Animal
    {
        public Cat()
        {
            Name = "cat";
            Voice = "mewaoo";
        }
        public override void DisplayAnimal()
        {
            Console.WriteLine("cat is showing");
        }

        public override void MakeSound()
        {
            Console.WriteLine("cat is meawing");
        }

      
    }
}
