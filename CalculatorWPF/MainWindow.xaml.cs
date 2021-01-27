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
			if (Double.TryParse(FirstArgument.Text, out double x) && Double.TryParse(SecondArgument.Text, out double y))
			{
				var result = CalculatorTests.Program.Add(x, y);
				Output.Content = result;
				OutputText.Content = "x + y = ";
			}
		}
		private void SubButton_Click(object sender, RoutedEventArgs e)
		{
			if (Double.TryParse(FirstArgument.Text, out double x) && Double.TryParse(SecondArgument.Text, out double y))
			{
				var result = CalculatorTests.Program.Subtract(x, y);
				Output.Content = result;
				OutputText.Content = "x - y = ";
			}
		}

		private void MultiplyButton_Click(object sender, RoutedEventArgs e)
		{
			if (Double.TryParse(FirstArgument.Text, out double x) && Double.TryParse(SecondArgument.Text, out double y))
			{
				var result = CalculatorTests.Program.Multiply(x, y);
				Output.Content = result;
				OutputText.Content = "x * y = ";
			}
		}

		private void DivideButton_Click(object sender, RoutedEventArgs e)
		{
			if (Double.TryParse(FirstArgument.Text, out double x) && Double.TryParse(SecondArgument.Text, out double y))
			{
				try
				{
					var result = CalculatorTests.Program.Divide(x, y);
					Output.Content = result;
					OutputText.Content = "x / y = ";
				}
				catch (DivideByZeroException)
				{
					OutputText.Content = "";
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
					OutputText.Content = "";
					Output.Content = "Division by 0!";
				}
			}
		}

		private void ExponentButton_Click(object sender, RoutedEventArgs e)
		{
			if (Double.TryParse(FirstArgument.Text, out double x) && Double.TryParse(SecondArgument.Text, out double y))
			{
				try
				{
					var result = CalculatorTests.Program.Exponent(x, y);
					Output.Content = result;
					OutputText.Content = "x ^ y = ";
				}
				catch (ArgumentException)
				{
					OutputText.Content = "";
					Output.Content = "0^0 is Undefined!";
				}
			}
		}
	}
}
