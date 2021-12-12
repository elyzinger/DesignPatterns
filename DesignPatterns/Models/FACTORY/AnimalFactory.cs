using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string animalName)
        {
            Animal newAnimal = null;

            if(animalName == "cat")
            {
                return newAnimal = new Cat();
            }
            else if(animalName =="dog")
            {
                return newAnimal = new Dog();
            }
            else
            {
                return null;
            }

        }
    }
}
