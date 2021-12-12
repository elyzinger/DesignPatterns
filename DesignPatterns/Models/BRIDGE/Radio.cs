using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.BRIDGE
{
    public class Radio : SoundDevice
    {
        public Radio(int channle, int maxChannel)
        {
            Channle = channle;
            MaxChannle = maxChannel;
        }
        public override void ButtonSixPressed()
        {
          
            Channle++;
            Console.WriteLine($"Channel Up To {Channle}");
        }

        public override void ButtonFourPressed()
        {
            
            Channle--;
            Console.WriteLine($"Channel Down To {Channle}");
        }
    }
}
