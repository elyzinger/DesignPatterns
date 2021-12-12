using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.BRIDGE
{
    class DvdRemote : Remote
    {
        public DvdRemote(SoundDevice device) : base(device)
        {

        }
        public override void ButtonFivePressed()
        {
            Console.WriteLine("Dvd Wad Paused");
        }
    }
}
