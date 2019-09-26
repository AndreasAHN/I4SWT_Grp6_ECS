namespace ECS.Refactored
{
    public class ECS
    {
        private int _lowerThreshold;
        private int _upperThreshold;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;
        private readonly IWindow _window;

        public ECS(IWindow window, IHeater heater, ITempSensor tempSensor)
        {
            _tempSensor = tempSensor;
            _heater = heater;
            _window = window;

        }

        public void Regulate()
        {
            var temp = _tempSensor.GetTemp();
            if (temp <= _lowerThreshold)
            {
                _heater.TurnOn();
                _window.Close();
            }
            else if (temp >= _lowerThreshold && temp <= _upperThreshold)
            {
                _heater.TurnOff();
                _window.Close();
            }
            else
            {
                _heater.TurnOff();
                _window.Open();
            }
        }

        public void SetUppperThreshold(int thr)
        {
            _upperThreshold = thr;
        }

        public int GetUppperThreshold()
        {
            return _upperThreshold;
        }

        public void SetLowerThreshold(int thr)
        {
            _lowerThreshold = thr;
        }

        public int GetLowerThreshold()
        {
            return _lowerThreshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        //public bool RunSelfTest()
        //{
        //    return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        //}
    }
}
