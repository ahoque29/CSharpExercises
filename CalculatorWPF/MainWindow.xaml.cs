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
using CalculatorTests;

namespace CalculatorWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			if (Int32.TryParse(FirstArgument.Text, out int x) && Int32.TryParse(SecondArgument.Text, out int y))
			{
				var result = CalculatorTests.Program.Add(x, y);
				Output.Content = result;
			}
		}
	}
}
