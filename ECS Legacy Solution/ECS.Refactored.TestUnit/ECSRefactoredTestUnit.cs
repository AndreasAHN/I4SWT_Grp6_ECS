using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ECS.Refactored;

namespace ECS.Refactored.TestUnit
{
    [TestFixture]
    public class ECSRefactoredTestUnit
    {
        private FakeTempSensor _fakeTempSensor;
        private FakeHeater _fakeHeater;
        private ECS _uut;
        private FakeWindow _fakeWindow;

        [SetUp]
        public void Setup()
        {
            // Create the fake stubs and mocks
            _fakeHeater = new FakeHeater();
            _fakeTempSensor = new FakeTempSensor();
            _fakeWindow = new FakeWindow();

            _uut = new ECS(_fakeTempSensor, _fakeHeater, _fakeWindow);
            _uut.SetLowerThreshold(25);
            _uut.SetUppperThreshold(28);
        }


    }
}
