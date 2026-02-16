using System;
using System.Collections.Generic;
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

        public void DisplayAll()
        {
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}, {p.City}, {p.State}");
            }
        }
    }
}
