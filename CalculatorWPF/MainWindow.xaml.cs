using System;
using System.Windows;

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
				OutputText.Content = "x + y = ";
			}
		}
		private void SubButton_Click(object sender, RoutedEventArgs e)
		{
			if (Int32.TryParse(FirstArgument.Text, out int x) && Int32.TryParse(SecondArgument.Text, out int y))
			{
				var result = CalculatorTests.Program.Subtract(x, y);
				Output.Content = result;
				OutputText.Content = "x - y = ";
			}
		}

		private void MultiplyButton_Click(object sender, RoutedEventArgs e)
		{
			if (Int32.TryParse(FirstArgument.Text, out int x) && Int32.TryParse(SecondArgument.Text, out int y))
			{
				var result = CalculatorTests.Program.Multiply(x, y);
				Output.Content = result;
				OutputText.Content = "x * y = ";
			}
		}

		private void DivideButton_Click(object sender, RoutedEventArgs e)
		{
			if (Int32.TryParse(FirstArgument.Text, out int x) && Int32.TryParse(SecondArgument.Text, out int y))
			{
				try
				{
					var result = CalculatorTests.Program.Divide(x, y);
					Output.Content = result;
					OutputText.Content = "x / y = ";
				}
				catch (DivideByZeroException)
				{
					Output.Content = "Division by 0!";
				}
			}
		}

		private void ModulusButton_Click(object sender, RoutedEventArgs e)
		{
			if (Int32.TryParse(FirstArgument.Text, out int x) && Int32.TryParse(SecondArgument.Text, out int y))
			{
				try
				{
					var result = CalculatorTests.Program.Modulus(x, y);
					Output.Content = result;
					OutputText.Content = "x % y = ";
				}
				catch (DivideByZeroException)
				{
					Output.Content = "Division by 0!";
				}
			}
		}
	}
}
