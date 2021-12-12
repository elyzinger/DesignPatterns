using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.BRIDGE
{
    public class RadioRemote : Remote
    {
        public RadioRemote(SoundDevice device) : base(device)
        {

        }

        public override void ButtonFivePressed()
        {
            Console.WriteLine("Radio Wad Muted");
        }
 
    }
}
