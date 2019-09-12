using System;

namespace ECS.Refactored
{
    internal class FakeTempSensor
    {
        private Random Fakegen = new Random();

        public int FakeGetTemp()
        {
            return Fakegen.Next(-5, 45);
        }

        public bool FakeRunSelfTest()
        {
            return true;
        }
    }
}