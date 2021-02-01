using NUnit.Framework;
using RadioApp;
namespace RadioTests
{
	public class RadioOffTests
	{
		private Radio _radio;
		[SetUp]
		public void Setup()
		{
			_radio = new Radio();
			_radio.TurnOff();
		}

		#region Channel Tests
		/// <summary>
		/// Tests for the Channel property and related methods
		/// </summary>
		/// <param name="newChannel"></param>

		[TestCase(1)]
		[TestCase(2)]
		[TestCase(3)]
		[TestCase(4)]
		public void ChangeToValidChannelWhenOffTest(int newChannel)
		{
			_radio.Channel = newChannel;
			Assert.AreEqual(1, _radio.Channel);
		}

		[TestCase(-1)]
		[TestCase(0)]
		[TestCase(5)]
		public void ChangeToInvalidChannelWhenOffTest(int newChannel)
		{
			// act
			_radio.Channel = newChannel;
			// assert
			Assert.AreEqual(1, _radio.Channel);
		}

		#endregion

		#region Volume Tests
		/// <summary>
		/// Tests for the Volume property and related methods
		/// </summary>
		/// <param name="newVolume"></param>

		[TestCase(0)]
		[TestCase(1)]
		[TestCase(2)]
		[TestCase(3)]
		[TestCase(4)]
		[TestCase(5)]
		public void ChangeToValidVolumeWhenOffTest(int newVolume)
		{
			_radio.Volume = newVolume;
			Assert.AreEqual(3, _radio.Volume);
		}


		[TestCase(-1)]
		[TestCase(6)]
		public void ChangeToInvalidVolumeWhenOffTest(int newVolume)
		{
			_radio.Volume = newVolume;
			Assert.AreEqual(3, _radio.Volume);
		}

		[Test]
		public void TurningUpVolumeDoesNotChangeVolumeWhenOff()
		{
			_radio.VolumeUp();
			Assert.AreEqual(3, _radio.Volume);
		}

		[Test]
		public void TurningDownVolumeDoesNotChangeVolumeWhenOff()
		{
			_radio.VolumeDown();
			Assert.AreEqual(3, _radio.Volume);
		}

		#endregion

		#region Other Tests

		[Test]
		public void PlayTest()
		{
			// act
			var message = _radio.Play();
			// assert
			Assert.AreEqual("Radio is off", message);
		}

		[Test]
		public void TurnOnTest()
		{
			_radio.TurnOn();
			Assert.AreEqual("Playing channel 1", _radio.Play());
		}

		#endregion
	}
}