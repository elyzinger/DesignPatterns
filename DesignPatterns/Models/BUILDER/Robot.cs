using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Robot 
    {
        private string robotArms;
        private string robotHead;
        private string robotlegs;
        private string robotTorso;
        public string RobotArms
        {
            get
            {
                return robotArms;
            }
            set 
            {
                robotArms = value;
            }

        }
        public string RobotHead
        {
            get
            {
                return robotHead;
            }
            set
            {
                robotHead = value;
            }

        }
        public string RobotLegs
        {
            get
            {
                return robotlegs;
            }
            set
            {
                robotlegs = value;
            }

        }
        public string RobotTorso
        {
            get
            {
                return robotTorso;
            }
            set
            {
                robotTorso = value;
            }

        }

        public override string ToString()
        {
            return $"Robot Parts - RobotHead: {RobotHead}, RobotTorso: {RobotTorso}, RobotArms: {RobotArms}, RobotLegs: {RobotLegs}";
        }
    }
}
