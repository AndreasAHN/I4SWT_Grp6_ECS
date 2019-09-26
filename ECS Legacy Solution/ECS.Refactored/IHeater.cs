using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored
{
    public interface IHeater
    {
        void TurnOn();
        void TurnOff();
        //bool RunSelfTest();
    }
}
