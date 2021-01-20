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
			try
			{
				return x / y;
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Cannot Divide by 0.");
				return 0;
			}
		}

		public static int Modulus(int x, int y)
		{
			return 0;
		}
		
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
