namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;

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

        public void TurnOn()
        {
            _on = true;
        }

        public void TurnOff()
        {
            _on = false;
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
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}