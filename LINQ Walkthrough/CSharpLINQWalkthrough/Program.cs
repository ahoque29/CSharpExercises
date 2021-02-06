using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLINQWalkthrough
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create a data source by using a collection initialiser.
			List<Student> students = new List<Student>
			{
				new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
				new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
				new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
				new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
				new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
				new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
				new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
				new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
				new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
				new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
				new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
				new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}
			};

			students.Add(new Student { First = "Ashib", Last = "Hoque", ID = 200, Scores = new List<int> { 95, 99, 90, 56 } });

			//// create the query
			//var studentQuery =
			//	from student in students
			//	where student.Scores[0] > 90 && student.Scores[3] < 80
			//	orderby student.Last descending
			//	select student;

			//var studentQuery2 =
			//	from student in students
			//	group student by student.Last[0] into studentGroup
			//	orderby studentGroup.Key
			//	select studentGroup;

			//var studentQuery3 =
			//	from student in students
			//	let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
			//	where totalScore / 4 < student.Scores[0]
			//	select student.Last + " " + student.First;

			var studentQuery4 =
				from student in students
				let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
				select totalScore;

			double averageScore = studentQuery4.Average();
			Console.WriteLine($"Class average score = {averageScore}");

			IEnumerable<string> studentQuery7 =
				from student in students
				where student.Last == "Garcia"
				select student.First;

			var studentQuery8 =
				from student in students
				let x = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
				where x > averageScore
				select new { id = student.ID, score = x };

			foreach (var i in studentQuery8)
			{
				Console.WriteLine($"Student ID: {i.id}, Score: {i.score}");
			}
		}
	}
	public class Student
	{
		public string First { get; set; }
		public string Last { get; set; }
		public int ID { get; set; }
		public List<int> Scores;

	}

}
