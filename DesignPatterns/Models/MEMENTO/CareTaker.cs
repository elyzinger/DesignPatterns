using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.MEMENTO
{
    class CareTaker
    {
        public List<Memento> savedMementos = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            savedMementos.Add(memento);
        }
        public Memento GetMemento(int index)
        {
            return savedMementos[index];
        }
    }
}
