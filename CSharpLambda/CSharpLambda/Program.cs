using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLambda
{
	
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };
			var count = nums.Count;

			int countEven = 0;
			foreach (var n in nums)
			{
				if (IsEven(n))
				{
					countEven++;
				}
			}

			int allCount = nums.Count();
			int linqCount = nums.Count(IsEven);
			int oddCount = nums.Count(IsOdd);
			List<Person> people = new List<Person>()
			{
				new Person { Name = "Cathy", Age = 40 },
				new Person { Name = "Nish", Age = 55 },
				new Person { Name = "Martin", Age = 19 }
			};

			var youngPeopleCount = people.Count(IsYoung);
		}

		private static bool IsEven(int n)
		{
			return n % 2 == 0;
		}

		private static bool IsOdd(int n)
		{
			return n % 2 != 0;
		}

		public static bool IsYoung(Person p)
		{
			return p.Age < 30;
		}

		public class Person
		{
			public string Name { get; set; }
			public int Age { get; set; }
		}
	}
}
