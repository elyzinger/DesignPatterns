using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Command
{
    interface Command
    {
        public void Execute();

        public void Undo();
    }

    public class TurnOn : Command
    {
        Device device;

        public TurnOn(Device newDevice)
        {
            device = newDevice;
        }

        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
    public class TurnOff : Command
    {
        Device device;

        public TurnOff(Device newDevice)
        {
            device = newDevice;
        }
        public void Execute()
        {
            device.Off();
        }
        public void Undo()
        {
            device.On();
        }
    }
    public class BrightUp : Command
    {
        Device device;

        public BrightUp(Device newDevice)
        {
            device = newDevice;
        }
        public void Execute()
        {
            device.MoreBright();
        }
        public void Undo()
        {
            device.LessBright();
        }
    }
    public class BrightDown : Command
    {
        Device device;

        public BrightDown(Device newDevice)
        {
            device = newDevice;
        }
        public void Execute()
        {
            device.LessBright();
        }
        public void Undo()
        {
            device.MoreBright();
        }
    }
}
