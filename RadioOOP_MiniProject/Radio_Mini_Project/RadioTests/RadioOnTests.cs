using NUnit.Framework;
using RadioApp;
namespace RadioTests
{
	public class RadioOnTests
	{
		private Radio _radio;
		[SetUp]
		public void Setup()
		{
			_radio = new Radio();
			_radio.TurnOn();
		}

		#region Channel Tests
		/// <summary>
		/// Tests for the channel parameter and related parameters
		/// </summary>
		/// <param name="newChannel"></param>

		[TestCase(1)]
		[TestCase(2)]
		[TestCase(3)]
		[TestCase(4)]
		public void ChangeToValidChannelTest(int newChannel)
		{
			_radio.Channel = newChannel;
			Assert.AreEqual(newChannel, _radio.Channel);
		}

		[TestCase(-1)]
		[TestCase(0)]
		[TestCase(5)]
		public void ChangeToInvalidChannelTest(int newChannel)
		{
			// arrange
			_radio.Channel = 2;
			// act
			_radio.Channel = newChannel;
			// assert
			Assert.AreEqual(2, _radio.Channel);
		}

		#endregion

		#region Volume Tests
		/// <summary>
		/// Tests for the Volume Parameter and related methods.
		/// </summary>
		/// <param name="newVolume"></param>

		[TestCase(0)]
		[TestCase(1)]
		[TestCase(2)]
		[TestCase(3)]
		[TestCase(4)]
		[TestCase(5)]
		public void ChangeToValidVolume(int newVolume)
		{
			_radio.Volume = newVolume;
			Assert.AreEqual(newVolume, _radio.Volume);
		}

		[TestCase(-1)]
		[TestCase(6)]
		public void ChangeToInvalidVolumeTest(int newVolume)
		{
			_radio.Volume = newVolume;
			Assert.AreEqual(3, _radio.Volume);
		}

		[Test]
		public void TurningUpVolumeSetsTheVolumeCorrectly()
		{
			_radio.VolumeUp();
			Assert.AreEqual(4, _radio.Volume);
		}

		[Test]
		public void TurningUpVolumePastMaxDoesNotIncreaseVolume()
		{
			_radio.Volume = 5;
			_radio.VolumeUp();
			Assert.AreEqual(5, _radio.Volume);
		}

		[Test]
		public void TurningDownVolumeSetsTheVolumeCorrectly()
		{
			_radio.VolumeDown();
			Assert.AreEqual(2, _radio.Volume);
		}

		[Test]
		public void TurningDownVolumeBelowMinDoesNotDecreaseVolume()
		{
			_radio.Volume = 0;
			_radio.VolumeDown();
			Assert.AreEqual(0, _radio.Volume);
		}

		#endregion

		#region Other Tests

		[Test]
		public void PlayTest()
		{
			// arrange
			_radio.Channel = 4;
			// act
			var message = _radio.Play();
			// assert
			Assert.AreEqual("Playing channel 4", message);
		}

		[Test]
		public void TurnOffTest()
		{
			_radio.TurnOff();
			Assert.AreEqual("Radio is off", _radio.Play());
		}

		#endregion
	}
}