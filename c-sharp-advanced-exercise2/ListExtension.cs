using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_advanced_exercise2;

namespace c_sharp_advanced_exercise2
{
    internal static class ListExtension
    {
        public static string printAllPeopleNames(this List<Person> people)
        {
            StringBuilder sb = new StringBuilder();
            Console.ForegroundColor = ConsoleColor.Red;
            if (people.Count == 0) return "There are no people on the list";
            Console.ResetColor();

            sb.AppendLine($"{people.Count} people");
            foreach (Person person in people)
            {
                sb.AppendLine(person.Name);
            }

            return sb.ToString();
        }
        public static void printAllPeople(this List<Person> people)
        {
            if (people.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are no people");
                Console.ResetColor();
            }
            else
            {
                foreach (Person person in people)
                {
                    Console.WriteLine(person.printPerson);
                }
            }
        }
    }
}
