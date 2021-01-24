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
		public void DivisionIsCorrect_GivenSecondArgumentIsNotZero(int a, int b, int expectedResult)
		{
			var result = Program.Divide(a, b);
			Assert.AreEqual(expectedResult, result);
		}

		[TestCase(5, 0)]
		[TestCase(-2, 0)]
		public void DivisionReturnsException_GivenSecondArgumentIsZero(int a, int b)
		{
			var ex = Assert.Throws<System.DivideByZeroException>(() => Program.Divide(a, b));
		}

		[TestCase(3, 2, 1)]
		[TestCase(-9, 4, -1)]
		public void ModulusIsCorrect_GivenSecondArgumentIsNotZero(int a, int b, int expectedResult)
		{
			var result = Program.Modulus(a, b);
			Assert.AreEqual(expectedResult, result);
		}

		[TestCase(9, 0)]
		[TestCase(-16, 0)]
		public void ModulusReturnsException_GivenSecondArgumentIsZero(int a, int b)
		{
			var ex = Assert.Throws<System.DivideByZeroException>(() => Program.Modulus(a, b));
		}

	}
}