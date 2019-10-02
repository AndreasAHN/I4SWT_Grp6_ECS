using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ECS.Refactored;
using NSubstitute;

namespace ECS.Refactored.TestUnit
{
    [TestFixture]
    public class ECSRefactoredTestUnit
    {
        private ITempSensor _fakeTempSensor;
        private IHeater _fakeHeater;
        private ECS _uut;
        private IWindow _fakeWindow;

        [SetUp]
        public void Setup()
        {
            _fakeHeater = Substitute.For<IHeater>();
            _fakeTempSensor = Substitute.For<ITempSensor>();
            _fakeWindow = Substitute.For<IWindow>();

            _uut = new ECS( _fakeWindow, _fakeHeater, _fakeTempSensor);
            _uut.SetLowerThreshold(25);
            _uut.SetUppperThreshold(28);
        }


        [Test]
        public void RunSelfTests()
        {
            _fakeTempSensor.RunSelfTest().Returns(false);
            _fakeHeater.RunSelfTest().Returns(false);
            Assert.IsFalse(_uut.RunSelfTest());
        }

        

    }
}
