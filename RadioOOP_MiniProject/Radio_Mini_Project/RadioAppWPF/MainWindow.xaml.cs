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

		private void On_RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			radio.TurnOn();
			RadioOutput.Content = radio.Play();
		}
		private void Off_RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			radio.TurnOff();
			RadioOutput.Content = radio.Play();
		}

		private void Channel1_Button_Click(object sender, RoutedEventArgs e)
		{
			radio.Channel = 1;
			RadioOutput.Content = radio.Play();
		}

		private void Channel2_Button_Click(object sender, RoutedEventArgs e)
		{
			radio.Channel = 2;
			RadioOutput.Content = radio.Play();
		}

		private void Channel3_Button_Click(object sender, RoutedEventArgs e)
		{
			radio.Channel = 3;
			RadioOutput.Content = radio.Play();
		}

		private void Channel4_Button_Click(object sender, RoutedEventArgs e)
		{
			radio.Channel = 4;
			RadioOutput.Content = radio.Play();
		}
	}
}
