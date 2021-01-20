using NUnit.Framework;

namespace CalculatorTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(2, 3, 5)]
		[TestCase(5, 10, 15)]
		public void AddIsCorrect(int a, int b, int expectedResult)
		{
			var result = Program.Add(a, b);
			Assert.AreEqual(expectedResult, result);
		}

		[TestCase(5, 10, -5)]
		[TestCase(23, 3, 20)]
		public void SubtractIsCorrect(int a, int b, int expectedResult)
		{
			var result = Program.Subtract(a, b);
			Assert.AreEqual(expectedResult, result);
		}

		[TestCase(5, 10, 50)]
		[TestCase(7, 3, 21)]
		public void MultiplyIsCorrect(int a, int b, int expectedResult)
		{
			var result = Program.Multiply(a, b);
			Assert.AreEqual(expectedResult, result);
		}

		[TestCase(10, 5, 2)]
		[TestCase(9, 2, 4)]
		[TestCase(-8, 2, -4)]
		[TestCase(-4, -2, 2)]
		[TestCase(20, -10, -2)]
		[TestCase(23, 0, 0)]
		public void DivisionIsCorrect(int a, int b, int expectedResult)
		{
			var result = Program.Divide(a, b);
			Assert.AreEqual(expectedResult, result);
		}
	}
}