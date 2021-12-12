using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.MEMENTO
{
    class Originator
    {
        public string Artical { get; set; }

        Memento articalMemento;
    
      
        public Memento SaveArticalInMemento()
        {
            articalMemento = new Memento(Artical);
            return articalMemento;
        }

        public string LaodArticalFromMemento()
        {
            return Artical = articalMemento.GetMemento();
        }
    }
}
