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

        public static void AddPerson(PersonCreateVM viewModel)
        {
            var person = new Person
            {
                Name = viewModel.Name,
                Email = viewModel.Email
            };
            if (persons.Count > 0)
                person.Id = persons.Max(p => p.Id) + 1;
            else
                person.Id = 1;

            persons.Add(person);
        }

        public static PeopleIndexVM[] GetAllPeople()
        {
            return persons
                .Select(p => new PeopleIndexVM(p.Id)
                {
                    Name = p.Name,
                    Email = p.Email,
                    ShowAsHighlighted = p.Email.EndsWith("acme.com")
                })
                .ToArray();
        }

        public static PersonUpdateVM GetPerson(int id)
        {
            Person person = GetPersonFromList(id);
            return new PersonUpdateVM
            {
                Name = person.Name,
                Email = person.Email,
            };
        }

        private static Person GetPersonFromList(int id)
        {
            return persons
                 .SingleOrDefault(p => p.Id == id);
        }

        public static void UpdatePerson(PersonUpdateVM viewModel, int id)
        {
            var personToUpdate = GetPersonFromList(id);

            personToUpdate.Name = viewModel.Name;
            personToUpdate.Email = viewModel.Email;

        }
    }
}
