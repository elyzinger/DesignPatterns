using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class RobotEngineer
    {
        private RobotBuilderInterface robotBuilder;

        public RobotEngineer(RobotBuilderInterface robotBuilder)
        {
            this.robotBuilder = robotBuilder;                       
        }

        public Robot GetRobot()
        {
            return this.robotBuilder.GetRobot();
        }

        public void MakeRobot()
        {
            robotBuilder.BuildRobotHead();
            robotBuilder.BuildRobotArms();
            robotBuilder.BuildRobotTorso();
            robotBuilder.BuildRobotLegs();

        }
    }
}
