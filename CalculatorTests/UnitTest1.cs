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
	}
}