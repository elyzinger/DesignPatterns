using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.MEMENTO
{
    class Memento
    {
        public string SavedMemento{ get; set; }

        public Memento(string newSavedMemento)
        {
            SavedMemento = newSavedMemento;
        }

        public string GetMemento()
        {
            return SavedMemento;
        }
    }
}
