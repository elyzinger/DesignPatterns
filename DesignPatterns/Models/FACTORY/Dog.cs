using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
   public class Dog : Animal
    {
        public Dog()
        {
            Name = "dog";
            Voice = "bark";
        }
        public override void DisplayAnimal()
        {
            Console.WriteLine("dog is showing");
        }

        public override void MakeSound()
        {
            Console.WriteLine("dog is barking");
        }
 
    }
}
