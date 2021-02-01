using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadioApp;

namespace RadioAppWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Radio radio = new Radio();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void OnOff_Click(object sender, RoutedEventArgs e)
		{
			switch (((Button)sender).Name)
			{
				case "OnButton":
					radio.TurnOn();
					VolumeOutput.Text = "";
					for (int i = 0; i < radio.Volume; i++)
					{
						VolumeOutput.Text += "|||||||";
					}
					break;
				case "OffButton":
					radio.TurnOff();
					VolumeOutput.Text = "";
					break;
			}
			RadioOutput.Text = radio.Play();
		}

		private void Channel_Button_Click(object sender, RoutedEventArgs e)
		{
			switch (((Button)sender).Name)
			{
				case "Channel1_Button":
					radio.Channel = 1;
					break;
				case "Channel2_Button":
					radio.Channel = 2;
					break;
				case "Channel3_Button":
					radio.Channel = 3;
					break;
				case "Channel4_Button":
					radio.Channel = 4;
					break;
			}
			RadioOutput.Text = radio.Play();
		}

		private void Volume_Button_Click(object sender, RoutedEventArgs e)
		{
			switch (((Button)sender).Name)
			{
				case "VolumeUp_Button":
					radio.VolumeUp();
					break;
				case "VolumeDown_Button":
					radio.VolumeDown();
					break;
			}

			if (radio._on)
			{
				VolumeOutput.Text = "";
				for (int i = 0; i < radio.Volume; i++)
				{
					VolumeOutput.Text += "|||||||";
				}
			}
		}

		private void Colour_Button_Click(object sender, RoutedEventArgs e)
		{
			switch (((Button)sender).Name)
			{
				case "eeeColour_Button":
					OverallBorder.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xEE, 0xEE, 0xEE));
					break;
				case "PurpleColour_Button":
					OverallBorder.Background = Brushes.Purple;
					break;
				case "TurquoiseColour_Button":
					OverallBorder.Background = Brushes.MediumTurquoise;
					break;
				case "YellowColour_Button":
					OverallBorder.Background = Brushes.Yellow;
					break;
			}
		}
	}
}
