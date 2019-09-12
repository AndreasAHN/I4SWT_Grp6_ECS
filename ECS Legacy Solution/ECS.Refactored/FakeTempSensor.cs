using System;

namespace ECS.Refactored
{
    internal class FakeTempSensor : ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);

        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
   

}

