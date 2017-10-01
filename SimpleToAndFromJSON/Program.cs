using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToAndFromJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.Age = 25;
            person.Country = "Sweden";
            persons.Add(person);

            person = new Person();
            person.FirstName = "Jane";
            person.LastName = "Doe";
            person.Age = 30;
            person.Country = "Finland";
            persons.Add(person);

            person = new Person();
            person.FirstName = "Baby";
            person.LastName = "Doe";
            person.Age = 2;
            person.Country = "Norway";
            persons.Add(person);

            // Serialization of a List<Person>
            string json = JsonConvert.SerializeObject(persons);
            Console.WriteLine("Persons serialized into json-format: ");
            Console.WriteLine(json);
            Console.WriteLine();

            // Deserialization of a List<Person>
            List<Person> newPersonList = JsonConvert.DeserializeObject<List<Person>>(json);
            Console.WriteLine("Persons deserialized from json-format: ");
            foreach (Person t in newPersonList)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName}, {t.Age}, {t.Country}");
            }
        }
    }
}
