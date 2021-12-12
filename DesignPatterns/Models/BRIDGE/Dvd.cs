using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.BRIDGE
{
    class Dvd : SoundDevice
    {
        public Dvd(int movieNum, int maxMovie)
        {
            Channle = movieNum;
            MaxChannle = maxMovie;
        }
        public override void ButtonFourPressed()
        {
            Console.WriteLine($"Next Movie Number {Channle}");
            Channle++;
        }

        public override void ButtonSixPressed()
        {
            Console.WriteLine($"Go Back to Movie Number {Channle}");
            Channle--;
        }
    }
}
