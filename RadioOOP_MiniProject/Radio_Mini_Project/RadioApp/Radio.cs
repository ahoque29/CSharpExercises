namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on;
        private int _volume = 3;

        public int Channel
        {
            get
            {
                return _channel;
            }
            set
            {
                if (_on && value > 0 && value < 5)
                {
                    _channel = value;
				}
			}
        }

        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (_on && value >= 0 && value < 6)
                {
                    _volume = value;
                }
            }
        }

        public void TurnOn()
        {
            _on = true;
        }

        public void TurnOff()
        {
            _on = false;
        }

        public void VolumeUp()
        {
            Volume++;
        }

        public void VolumeDown()
        {
            Volume--;
        }

        public string Play()
        {
            if (!_on)
            {
                return "Radio is off";
            }
            return $"Playing channel {Channel}";
        }
    }
}