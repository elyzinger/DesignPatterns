using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.OBSERVER
{
    public interface Subject
    {
        public void Register(Observer newObserver);
        public void Unregister(Observer observerToRemove);
        public void NotifyObserver();
    }
}
