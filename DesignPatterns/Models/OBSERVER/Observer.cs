using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.OBSERVER
{
    public interface Observer
    {
        
        public void Update(double newCelsius, double newFahrenheit);
    }
}
