using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class OldRobotBuilde : RobotBuilderInterface
    {
        private Robot robot;

        public OldRobotBuilde()
        {
            this.robot = new Robot();
        }
        public void BuildRobotArms()
        {
            robot.RobotArms = "Steel Arms";
        }

        public void BuildRobotHead()
        {
            robot.RobotHead = "Steel Head";
        }

        public void BuildRobotLegs()
        {
            robot.RobotLegs = "Steel Legs";
        }

        public void BuildRobotTorso()
        {
            robot.RobotTorso = "Steel Torso";
        }

        public Robot GetRobot()
        {
            return this.robot;
        }
    }
}
