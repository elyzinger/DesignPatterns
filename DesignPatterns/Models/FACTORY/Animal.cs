using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
   public abstract class Animal
    {
        public string Name { get; set; }
        public string Voice{ get; set; }


        public abstract void MakeSound();
        public abstract void DisplayAnimal();

     
    }
  
}
