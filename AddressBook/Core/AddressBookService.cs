using System;
using System.Collections.Generic;
using System.Linq;
using AddressBook.Models;

namespace AddressBook.Core
{
    // Custom Exception for Duplicate Email
    public class DuplicateEmailException : Exception
    {
        public DuplicateEmailException(string message) : base(message) { }
    }

    public class AddressBookService
    {
        private List<Person> persons = new List<Person>();

        public void AddPerson(Person person)
        {
            // Check duplicate by Name
            if (persons.Contains(person))
            {
                throw new Exception("Duplicate person (same FirstName and LastName) not allowed!");
            }

            // Check duplicate by Email
            if (persons.Any(p => p.Email == person.Email))
            {
                throw new DuplicateEmailException("Email already exists! Duplicate email not allowed.");
            }

            persons.Add(person);
        }

        public List<Person> SortByName()
        {
            return persons.OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList();
        }

        public List<Person> SortByCity()
        {
            return persons.OrderBy(p => p.City).ToList();
        }

        public List<Person> SortByState()
        {
            return persons.OrderBy(p => p.State).ToList();
        }

        public List<Person> SortByZip()
        {
            return persons.OrderBy(p => p.Zip).ToList();
        }

        public void DisplayAll()
        {
            foreach (var p in persons)
            {
                Console.WriteLine(p);
            }
        }
    }
}
