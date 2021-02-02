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
			var youngPeopleCount2 = people.Count(p => p.Age < 30);
			var totalAge = people.Sum(p => p.Age);
			var averageAge = people.Average(p => p.Age);
			var oldPeopleTotalAge = people.Sum(p => p.Age >= 30 ? p.Age : 0);

			var evenDelegateCount = nums.Count(delegate (int n) { return n % 2 == 0; });
			var evenLambdaCount = nums.Count(n => n % 2 == 0);

			
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

			public override string ToString() => $"{Name} is {Age} year{((Age > 1) ? "s" : "")} old";
		}
	}
}
