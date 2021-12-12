using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.BRIDGE
{
    public abstract class SoundDevice
    {
        private int channle = 0;
        public int Channle {
            get
            {
                return channle;
            }
  
            set
            {
                if(value < 0 || MaxChannle < channle)
                {
                    channle = 0;
                }
                else
                {
                    channle = value;
                }
            } 
        }

        public int MaxChannle { get; set; }

        public int Volume { get; set; }
        public abstract void ButtonFourPressed();
        public abstract void ButtonSixPressed();

        public void ButtonEightPressed()
        {
            Console.WriteLine($"Volume Up To {Volume}");
            Volume++;
        }
        public void ButtonTwoPressed()
        {
            Console.WriteLine($"Volume Up To {Volume}");
            Volume--;
        }




    }
}
