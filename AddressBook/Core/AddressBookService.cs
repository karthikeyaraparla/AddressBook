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
        }

        public List<Person> SortByName()
        {
            return persons.OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList();
        }
    }
}
