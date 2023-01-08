using System;
using System.Text;
using c_sharp_advanced_exercise2;
/// <summary>
/// Summary description for Person
/// </summary>
namespace c_sharp_advanced_exercise2
{
	public class Person
	{
		public string Name { get; set; }
		public string Id { get; set; }
		public List<Hobby> Hobbies { get; set; }
		public List<string> PersonalityTraits { get; set; }

		private int _age;
		public int Age
		{
			get { return _age; }
			set { if (value > 0) _age = value; }
		}
		public void addHobby(Hobby hobby)
		{
			Hobbies.Add(hobby);

		}
		public void addPersonalityTraits(string personalityTraits)
		{
			PersonalityTraits.Add(personalityTraits);
		}

		public string printPerson => $"Name: {Name}, Age: {Age}, ID: {Id}.";
		public string printPersonDetailes()
		{
			StringBuilder sb = new();
			sb.AppendLine($"Name: {Name}");
			sb.AppendLine($"Age: {Age}");
			sb.AppendLine($"ID: {Id}");
			sb.AppendLine("Hobbies:");
			if (Hobbies.Count > 0)
			{
				foreach (Hobby hobby in Hobbies)
				{
					sb.AppendLine($" * {hobby.HobbyName} - ({hobby.HoursPerWeek} Hours Per Week)");
				}
			}
			else { sb.AppendLine(" None"); }

			sb.AppendLine("Personality traits:");
			if (PersonalityTraits.Count > 0)
			{
				foreach (string trait in PersonalityTraits)
				{
					sb.AppendLine($" * {trait}");
				}
			}
			else { sb.AppendLine(" None"); }

			Console.WriteLine(sb.ToString());
			return sb.ToString();
		}
	}
}