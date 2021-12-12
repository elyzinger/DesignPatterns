using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Command
{
    public interface Device
    {
        public void On();
        public void Off();
        public void MoreBright();
        public void LessBright();
    }

    public class Screen : Device
    {
        public int LightLevel{ get; set; }
        public void LessBright()
        {
            LightLevel--;
            Console.WriteLine($"Screen Light Level Got Lower To {LightLevel}");
        }

        public void MoreBright()
        {
            LightLevel++;
            Console.WriteLine($"Screen Light Level Got Higher To {LightLevel}");
        }

        public void Off()
        {
            Console.WriteLine("Screen Is Off");
        }

        public void On()
        {
            Console.WriteLine("Screen Is On");
        }
    }
    public class Phone : Device
    {
        public int LightLevel { get; set; }
        public void LessBright()
        {
            LightLevel--;
            Console.WriteLine($"Phone Light Level Got Lower To {LightLevel}");
        }

        public void MoreBright()
        {
            LightLevel++;
            Console.WriteLine($"Phone Light Level Got Higher To {LightLevel}");
        }

        public void Off()
        {
            Console.WriteLine("Phone Is Off");
        }

        public void On()
        {
            Console.WriteLine("Phone Is On");
        }
    }
}
