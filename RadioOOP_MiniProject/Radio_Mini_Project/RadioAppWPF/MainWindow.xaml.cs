using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using RadioApp;

namespace RadioAppWPF
{

	public partial class MainWindow : Window
	{
		#region Contructor and Loading

		Radio radio = new Radio();
		MediaPlayer mediaPlayer = new MediaPlayer() { Volume = 0.6 };
		Uri Channel1_Track = new Uri(@"C:\Users\Ashib\Documents\Sparta\CSharpExercises\CSharpExercises\RadioOOP_MiniProject\Radio_Mini_Project\RadioAppWPF\ChannelTracks\Channel1_Music.mp3");
		Uri Channel2_Track = new Uri(@"C:\Users\Ashib\Documents\Sparta\CSharpExercises\CSharpExercises\RadioOOP_MiniProject\Radio_Mini_Project\RadioAppWPF\ChannelTracks\Channel2_Music.mp3");
		Uri Channel3_Track = new Uri(@"C:\Users\Ashib\Documents\Sparta\CSharpExercises\CSharpExercises\RadioOOP_MiniProject\Radio_Mini_Project\RadioAppWPF\ChannelTracks\Channel3_Music.mp3");
		Uri Channel4_Track = new Uri(@"C:\Users\Ashib\Documents\Sparta\CSharpExercises\CSharpExercises\RadioOOP_MiniProject\Radio_Mini_Project\RadioAppWPF\ChannelTracks\Channel4_Music.mp3");

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			RadioOutput.Text = "Hello!";
		}
		#endregion

		#region Turning Radio On/Off

		private void OnOff_Click(object sender, RoutedEventArgs e)
		{
			var animationOn = new ColorAnimation()
			{
				From = Colors.DarkGreen,
				To = Colors.LightGray,
				Duration = new Duration(TimeSpan.FromSeconds(2))
			};

			var animationOff = new ColorAnimation
			{
				From = Colors.DarkRed,
				To = Colors.LightGray,
				Duration = new Duration(TimeSpan.FromSeconds(2))
			};

			switch (((Button)sender).Name)
			{
				case "OnButton":
					if (!radio.On)
					{
						OverallBorder.Background.BeginAnimation(SolidColorBrush.ColorProperty, animationOn);
					}
					radio.TurnOn();
					radio.Channel = 1;
					VolumeOutput.Text = "|";
					for (int i = 0; i < radio.Volume; i++)
					{
						VolumeOutput.Text += "|||||||";
					}
					mediaPlayer.Open(Channel1_Track);
					mediaPlayer.Play();
					break;
				case "OffButton":
					if (radio.On)
					{
						OverallBorder.Background.BeginAnimation(SolidColorBrush.ColorProperty, animationOff);
					}
					radio.TurnOff();
					VolumeOutput.Text = "";
					mediaPlayer.Close();
					break;
			}
			RadioOutput.Text = radio.Play();
		}
		#endregion

		#region Channel Buttons

		private void Channel_Button_Click(object sender, RoutedEventArgs e)
		{
			switch (((Button)sender).Name)
			{
				case "Channel1_Button":
					radio.Channel = 1;
					if (radio.On)
					{
						mediaPlayer.Open(Channel1_Track);
						mediaPlayer.Play();
					}
					break;
				case "Channel2_Button":
					radio.Channel = 2;
					if (radio.On)
					{
						mediaPlayer.Open(Channel2_Track);
						mediaPlayer.Play();
					}
					break;
				case "Channel3_Button":
					radio.Channel = 3;
					if (radio.On)
					{
						mediaPlayer.Open(Channel3_Track);
						mediaPlayer.Play();
					}
					break;
				case "Channel4_Button":
					radio.Channel = 4;
					if (radio.On)
					{
						mediaPlayer.Open(Channel4_Track);
						mediaPlayer.Play();
					}
					break;
			}
			RadioOutput.Text = radio.Play();
		}

		#endregion

		#region Volume Buttons

		private void Volume_Button_Click(object sender, RoutedEventArgs e)
		{
			switch (((Button)sender).Name)
			{
				case "VolumeUp_Button":
					radio.VolumeUp();
					if (radio.On)
					{
						mediaPlayer.Volume += 0.2;
					}
					break;
				case "VolumeDown_Button":
					radio.VolumeDown();
					if (radio.On)
					{
						mediaPlayer.Volume -= 0.2;
					}
					break;
			}

			if (radio.On)
			{
				VolumeOutput.Text = "|";
				for (int i = 0; i < radio.Volume; i++)
				{
					VolumeOutput.Text += "|||||||";
				}
			}
		}

		#endregion
	}
}
