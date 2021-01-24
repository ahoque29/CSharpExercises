using System;

namespace CalculatorTests
{
	public class Program
	{
		public static int Add(int x, int y)
		{
			return x + y;
		}

		public static int Subtract(int x, int y)
		{
			return x - y;
		}

		public static int Multiply(int x, int y)
		{
			return x * y;
		}

		public static int Divide(int x, int y)
		{
			if (y == 0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				return x / y;
			}
		}

		public static int Modulus(int x, int y)
		{
			if (y == 0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				return x % y;
			}

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
