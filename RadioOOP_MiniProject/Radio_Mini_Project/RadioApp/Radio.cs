namespace RadioApp
{
	public class Radio
	{
		private int _channel = 1;
		private int _volume = 3;

		public bool On { get; private set; }

		public int Channel
		{
			get
			{
				return _channel;
			}
			set
			{
				if (On && value > 0 && value < 5)
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
				if (On && value >= 0 && value < 6)
				{
					_volume = value;
				}
			}
		}

		public void TurnOn()
		{
			On = true;
		}

		public void TurnOff()
		{
			On = false;
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
			if (!On)
			{
				return "Radio is off";
			}
			return $"Playing channel {Channel}";
		}
	}
}