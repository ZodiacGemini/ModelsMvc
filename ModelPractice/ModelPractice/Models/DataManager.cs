using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelPractice.Models
{
    static public class DataManager
    {
        static List<Person> persons = new List<Person>
        {
            new Person{Id = 1, Name = "Alexander", Email = "Alexander@hotmail.se"},
            new Person{Id = 2, Name = "Mats", Email = "Mats@hotmail.com"},
            new Person{Id = 3, Name = "Johanna", Email = "Johanna@hotmail.se"},
        };

        public static void AddPerson(Person person)
        {
            person.Id = persons.Max(p => p.Id) + 1;

            persons.Add(person);
        }

        public static Person[] GetAllPeople() => persons.ToArray();

        public static Person GetPerson(int id) => persons.SingleOrDefault(p => p.Id == id);

        public static void UpdatePerson(Person person)
        {
            var personToUpdate = GetPerson(person.Id);

            personToUpdate.Name = person.Name;
            personToUpdate.Email = person.Email;

        }
    }
}
