using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public interface RobotBuilderInterface
    {
        public void BuildRobotHead();
        public void BuildRobotTorso();
        public void BuildRobotArms();
        public void BuildRobotLegs();

        public Robot GetRobot();
    }
}
