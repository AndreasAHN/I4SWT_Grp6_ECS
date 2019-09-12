using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored
{
    public interface ITempSensor
    {
        Random Gen();
        int GetTemp();
        bool RunSelfTest();
    }
}
