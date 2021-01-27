using System;

namespace CalculatorTests
{
	public class Program
	{
		public static double Add(double x, double y)
		{
			return Math.Round(x + y, 3);
		}

		public static double Subtract(double x, double y)
		{
			return Math.Round(x - y, 3);
		}

		public static double Multiply(double x, double y)
		{
			return Math.Round(x * y, 3);
		}

		public static double Divide(double x, double y)
		{
			if (y == 0)
			{
				throw new DivideByZeroException();
			}
			
			return Math.Round(x / y, 3);
		}

		public static double Modulus(int x, int y)
		{
			if (y == 0)
			{
				throw new DivideByZeroException();
			}
			
			return x % y;

		}

		public static double Exponent(double x, double y)
		{
			if (x == 0 && y == 0)
			{
				throw new ArgumentException();
			}
			
			return Math.Round(Math.Pow(x, y), 3);
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
