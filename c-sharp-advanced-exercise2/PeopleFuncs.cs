using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_advanced_exercise2
{
    internal class PeopleFuncs
    {
        public static string beforeSearch(string value)
        {
            return value.Trim().ToLower();

        }
        public static Person createPerson(List<Person> people)
        {
            Console.WriteLine("Enter person name and press enter");
            string name = Console.ReadLine();
            Console.WriteLine("Enter person age and press enter");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter person ID and press enter");
            string id = Console.ReadLine();
            Person person = new()
            {
                Name = name,
                Age = age,
                Id = id,
                Hobbies = new List<Hobby>(),
                PersonalityTraits = new List<string>()
            };

            while (true)
            {
                Console.WriteLine("Enter hobby name or done to finish");
                string hobbyName = Console.ReadLine().Trim().ToLower();
                if (hobbyName == "done") break;

                Console.WriteLine("How many hours a week spends on this hobby?");
                double hoursPerWeekHobby = double.Parse(Console.ReadLine());

                person.addHobby(new Hobby(hobbyName, hoursPerWeekHobby));
            }
            while (true)
            {
                Console.WriteLine("Enter Personality trait or done to finish");
                string PersonalityTrait = Console.ReadLine().Trim().ToLower();
                if (PersonalityTrait == "done") break;

                person.addPersonalityTraits(PersonalityTrait);
            }
            people.Add(person);

            return person;
        }
        public static void deletePersonById(List<Person> people)
        {
            Console.WriteLine("Enter an ID:");
            string id = Console.ReadLine().Trim();
            Person personToDelete = findPersonById(people, id);

            if (personToDelete != null)
            {
                people.Remove(personToDelete);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("person is deleted");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("person not found");
            }
            Console.ResetColor();
        }
        public static void findPeople(List<Person> people)
        {
            Console.WriteLine("What would you like to search by? (choose a number)\n" +
                "1. ID\n" +
                "2. Name\n" +
                "3. Age\n" +
                "4. Age range\n" +
                "5. Hobbiy\n" +
                "6. Personality trait\n");

            string search = Console.ReadLine().Trim();
            string input;
            int age, age2;
            string result;
            switch (search)
            {
                case "1":
                    Console.WriteLine("Enter ID:");
                    input = Console.ReadLine().Trim().ToLower();
                    string answer = findPersonById(people, input)?.printPersonDetailes();
                    if (answer == null) Console.WriteLine("No person was found");
                    break;
                case "2":
                    Console.WriteLine("Enter name:");
                    input = Console.ReadLine().Trim().ToLower();
                    new List<Person>(findPersonByName(people, input)).printAllPeople();
                    break;
                case "3":
                    Console.WriteLine("Enter age:");
                    age = int.Parse(Console.ReadLine());
                    new List<Person>(findPersonByAge(people, age)).printAllPeople();
                    break;
                case "4":
                    Console.WriteLine("Enter first age:");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second age:");
                    age2 = int.Parse(Console.ReadLine());
                    new List<Person>(findPersonByAgeRange(people, age, age2)).printAllPeople();
                    break;
                case "5":
                    Console.WriteLine("Enter a hobby");
                    input = Console.ReadLine().Trim().ToLower();
                    new List<Person>(findPersonByHobby(people, input)).printAllPeople();
                    break;
                case "6":
                    Console.WriteLine("Enter a personality traits");
                    input = Console.ReadLine().Trim().ToLower();
                    new List<Person>(findPersonByPersonalityTraits(people, input)).printAllPeople();
                    break;
                default:
                    Console.WriteLine("Invalid input, Please try again.");
                    break;
            }
        }
        public static Person findPersonById(List<Person> people, string id)
        {
            return people.Find(person => person.Id == id);
        }
        public static List<Person> findPersonByName(List<Person> people, string name)
        {
            return people.Where(p => p.Name == name).ToList();
        }
        public static List<Person> findPersonByAge(List<Person> people, int age)
        {
            return people.Where(p => p.Age == age).ToList();
        }
        public static List<Person> findPersonByAgeRange(List<Person> people, int minAge, int maxAge)
        {
            if (minAge > maxAge)
            {
                int temperary = minAge;
                minAge = maxAge;
                maxAge = temperary;
            }
            return people.Where(p => p.Age >= minAge && p.Age <= maxAge).ToList();
        }
        public static List<Person> findPersonByHobby(List<Person> people, string hobbyName)
        {
            return people.Where(p => p.Hobbies.Any(h => h.HobbyName == hobbyName)).ToList();
        }
        public static List<Person> findPersonByPersonalityTraits(List<Person> people, string personalityTraits)
        {
            return people.FindAll(p => p.PersonalityTraits.Contains(personalityTraits));
        }
    }
}
