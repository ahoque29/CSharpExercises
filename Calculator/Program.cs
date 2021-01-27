using System;

namespace CalculatorTests
{
	public class Program
	{
		public static double Add(double x, double y)
		{
			double addOutput = x + y;
			if (addOutput > 999999)
			{
				throw new OverflowException();
			}
			return Math.Round(addOutput, 3);
		}

		public static double Subtract(double x, double y)
		{
			double subOutput = x - y;
			if (subOutput > 999999)
			{
				throw new OverflowException();
			}
			return Math.Round(subOutput, 3);
		}

		public static double Multiply(double x, double y)
		{
			double multiplyOutput = x * y;
			if (multiplyOutput > 999999)
			{
				throw new OverflowException();
			}
			return Math.Round(multiplyOutput, 3);
		}

		public static double Divide(double x, double y)
		{
			if (y == 0)
			{
				throw new DivideByZeroException();
			}
			double divideOutput = x / y;
			if (divideOutput > 999999)
			{
				throw new OverflowException();
			}
			return Math.Round(divideOutput, 3);
		}

		public static double Modulus(int x, int y)
		{
			if (y == 0)
			{
				throw new DivideByZeroException();
			}
			int modulusOutput = x % y;
			if (modulusOutput > 999999)
			{
				throw new OverflowException();
			}
			return modulusOutput;
		}

		public static double Exponent(double x, double y)
		{
			if (x == 0 && y == 0)
			{
				throw new ArgumentException();
			}

			double exponentOutput = Math.Pow(x, y);
			if (exponentOutput > 999999)
			{
				throw new OverflowException();
			}

			return Math.Round(exponentOutput, 3);
		}

		static void Main(string[] args)
		{
			try
			{
				
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (Exception)
			{
				Console.WriteLine("Unhandled exception.");
			}
		}
	}
}
