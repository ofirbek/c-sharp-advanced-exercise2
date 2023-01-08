using System.Text;

using c_sharp_advanced_exercise2;

namespace c_sharp_advanced_exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            enter10PeopleToDatabase(people);
            enter10PeopleToDatabase2(people);

            StringBuilder startMenu = new StringBuilder();
            startMenu.Append(
                "choose one of the options\n" +
                "1. enter new person\n" +
                "2. delete person\n" +
                "3. search\n" +
                "4. print all\n");

            while (true)
            {
                Console.WriteLine("\n" + startMenu.ToString());

                string input = Console.ReadLine().Trim();
                switch (input)
                {
                    case "1":
                        PeopleFuncs.createPerson(people);
                        break;
                    case "2":
                        PeopleFuncs.deletePersonById(people);
                        break;
                    case "3":
                        PeopleFuncs.findPeople(people);
                        break;
                    case "4":
                        Console.WriteLine(people.printAllPeopleNames());
                        break;
                    default:
                        Console.WriteLine("Invalid input, Please try again.");
                        break;
                }
            }
            /*            Console.WriteLine(people.printAllPeople());
            */
        }
        //=======================================================
        public static void enter10PeopleToDatabase2(List<Person> people)
        {
            Person person = new()
            {
                Name = "shlomi",
                Age = 22,
                Id = "22222222",
                Hobbies = new List<Hobby>
                {
                    new Hobby("play guitar", 12),
                    new Hobby("dance", 15),
                },
                PersonalityTraits = new List<string>
                {
                    "smart",
                    "happy",
                    "angry",
                }
            };
            people.Add(person);
            Person person2 = new()
            {
                Name = "lior",
                Age = 30,
                Id = "33333333",
                Hobbies = new List<Hobby>
                {
                    new Hobby("play guitar", 12),
                    new Hobby("eat", 15),
                },
                PersonalityTraits = new List<string>
                {
                    "happy",
                    "angry",
                }
            };
            people.Add(person2);
        }
        public static void enter10PeopleToDatabase(List<Person> people)
        {
            for (int i = 0; i < 10; i++)
            {
                Person person = new()
                {
                    Name = "ofir",
                    Age = 25 + i,
                    Id = "1111111" + (i + 1),
                    Hobbies = new List<Hobby>
                {
                    new Hobby("play guitar", 12),
                    new Hobby("play football", 6.5),
                    new Hobby("exercise", 12),
                    new Hobby("travel", 15),
                },
                    PersonalityTraits = new List<string>
                {
                    "smart",
                    "generous",
                    "sensitive",
                    "angry",
                }
                };
                people.Add(person);
            }
        }
    }
}