using System;
using System.Diagnostics;

namespace DataTypesPt2
{
	class Program
	{
		public enum Suit
		{
			HEARTS, CLUBS, DIAMONDS, SPADES
		}

		public enum Size
		{
			SMALL = 10, MEDIUM = 25, LARGE = 50
		}
		
		static void Main(string[] args)
		{
			Console.WriteLine("DataTypes2!!");
			Console.WriteLine();

			//var tps = TimeSpan.TicksPerSecond;
			//var nowInTicks = DateTime.Now.Ticks;
			//Console.WriteLine(tps);
			//Console.WriteLine(nowInTicks);

			////new date object mapped to midnight, 1 January 0001
			//var d = new DateTime();
			//var d1 = DateTime.Today;

			//var d2 = DateTime.Now;

			////literal date
			//var d3 = new DateTime(2020, 7, 12, 10, 5, 18);

			//// add one day
			//d = d.AddDays(1);
			//// add a month
			//d = d.AddMonths(1);

			//var output = DateTime.Now.ToString("dd-HH-yyyy");
			//var output2 = d.ToString("yyyy-MM-dd HH:mm:ss");

			//// 1 hour time span
			//var timespan = new TimeSpan(1, 0, 0);
			//// add this to time right now
			//d = DateTime.Now + timespan;

			//Console.WriteLine(d);

			//var s = new Stopwatch();
			//s.Start();
			//int total = 0;
			//for (int i = 0; i <= 100; i++)
			//{
			//	Console.WriteLine(total += i);
			//}
			//s.Stop();
			//Console.WriteLine(s.Elapsed);
			//Console.WriteLine(s.ElapsedMilliseconds);
			//Console.WriteLine(s.ElapsedTicks);

			//var d = new DateTime(1992, 12, 29, 0, 0, 0);			
			//var dNow = DateTime.Now;
			//var age = dNow - d;
			//Console.WriteLine(d.ToString("dd-MM-yyyy"));

			//Suit theSuit = Suit.HEARTS;
			//theSuit = Suit.DIAMONDS;

			//if (theSuit == Suit.SPADES)
			//{
			//	Console.WriteLine(theSuit);
			//}
			//else
			//{
			//	Console.WriteLine(theSuit);
			//}

			//Suit mySuit = (Suit)2;

			//var mediumValue = (int)Size.MEDIUM;
			//string mediumString = Size.MEDIUM.ToString();
			//Console.WriteLine($"{mediumString}: {mediumValue}");

			//Console.WriteLine($"{Size.MEDIUM}: {(int)Size.MEDIUM}");

			//Console.WriteLine($"Sunday as a number is {(int)DayOfWeek.Sunday}");

			//bool? hasPassed = null;
			//if (hasPassed.HasValue && hasPassed.Value)
			//{
			//	Console.WriteLine("Congrats!!");
			//}

			//int? items = 3;
			//if (items.HasValue)
			//{
			//	totalCost = items.Value * price;
			//}

			//int? nullableScore = null;
			//int score = nullableScore ?? -9999;
			//int score1 = nullableScore.GetValueOrDefault(-1);
			//int score2 = nullableScore.GetValueOrDefault();

			var rngSeeded = new Random();
			var between1and10 = rngSeeded.Next(1, 11);
			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine(between1and10);
			}
		}
	}
}
