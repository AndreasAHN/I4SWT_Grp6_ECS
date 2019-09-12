using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}
