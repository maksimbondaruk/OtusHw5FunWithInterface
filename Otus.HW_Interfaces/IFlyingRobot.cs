using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HW_Interfaces
{
    internal interface IFlyingRobot: IRobot
    {
        string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
