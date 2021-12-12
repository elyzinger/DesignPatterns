using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class MarcuryRobotBuilder : RobotBuilderInterface
    {
        private Robot robot;

        public MarcuryRobotBuilder()
        {
            this.robot = new Robot();
        }

        public void BuildRobotArms()
        {
            robot.RobotArms = "Marcury Arms";
        }

        public void BuildRobotHead()
        {
            robot.RobotHead = "Marcury Head";
        }

        public void BuildRobotLegs()
        {
            robot.RobotLegs = "Marcury Legs";
        }

        public void BuildRobotTorso()
        {
            robot.RobotTorso = "Marcury Torso";
        }

        public Robot GetRobot()
        {
            return this.robot;
        }
    }
}
