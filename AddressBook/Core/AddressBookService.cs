using System;
using System.Collections.Generic;
using System.Linq;
using AddressBook.Models;

namespace AddressBook.Core
{
    public class AddressBookService
    {
        private List<Person> persons = new List<Person>();

        public void AddPerson(Person person)
        {
            if (persons.Contains(person))
            {
                Console.WriteLine("Duplicate person not allowed!");
                return;
            }

            persons.Add(person);
            Console.WriteLine("Person added successfully!");
        }

        public List<Person> ViewByCity(string city)
        {
            return persons.Where(p => p.City == city).ToList();
        }

        public List<Person> ViewByState(string state)
        {
            return persons.Where(p => p.State == state).ToList();
        }

        public void DisplayAll()
        {
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}, {p.City}, {p.State}");
            }
        }
    }
}
