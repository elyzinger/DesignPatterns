using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.BRIDGE
{
    public abstract class Remote
    {
        private SoundDevice device;

        public Remote(SoundDevice newDevice)
        {
            device = newDevice;
        }
        public abstract void ButtonFivePressed();
       public void ButtonSixPressed()
        {
            device.ButtonSixPressed();
        }
        public void ButtonFourPressed()
        {
            device.ButtonFourPressed();
        }

        public void GetCurrentChannle()
        {
            Console.WriteLine(device.Channle); 
        }

    }
}
