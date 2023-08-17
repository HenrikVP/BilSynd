namespace BilSynd
{
    internal class Program
    {
        //static Person[] people = new Person[2];
        static List<Person> peopleList = new List<Person>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            new Person();
            Person p1 = new Person();
            p1.Firstname = "Grethe";
            p1.PhoneNumber = "1234567890";

            Person p2 = new Person();
            p2.Firstname = "Ursula";
            p2.PhoneNumber = "1234567890";
            Person.FirstStatic = "Something different";

            //people[0] = p1;
            //people[1] = p2;

            peopleList.Add(p1);
            peopleList.Add(p2);

            peopleList.Remove(p2);
            while (true)
            {
                Person person = CreatePerson();
                AddToArray(person);
                ShowPeople();
            }
        }

        static void ShowPeople()
        {
            foreach (Person person in peopleList)
            {
                if (person == null) continue;
                Console.WriteLine("Navn: " + person.Firstname);
            }
        }

        static void AddToArray(Person person)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == null)
                {
                    people[i] = person;
                    return;
                }
            }
            ExpandArray();
            people[people.Length - 1] = person;
        }

        static void ExpandArray()
        {
            Person[] temp = new Person[people.Length + 1];
            people.CopyTo(temp, 0);
            people = temp;
        }

        static void AddToList(Person person)
        {
            peopleList.Add(person);
        }

        static Person CreatePerson()
        {
            Person person = new Person();
            Console.WriteLine("What is thy name?");
            person.Firstname = Console.ReadLine();
            Console.WriteLine("What is thy number?");
            person.PhoneNumber = Console.ReadLine();
            return person;
        }
    }
}