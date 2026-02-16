using System.Collections.Generic;
using AddressBook.Models;
using System;

namespace AddressBook.Core
{
    public class AddressBookService
    {
        private List<Person> persons = new List<Person>();

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public void EditPerson(string firstName)
        {
            Person person = persons.Find(p => p.FirstName == firstName);

            if (person == null)
            {
                Console.WriteLine("Person not found!");
                return;
            }

            Console.Write("New Address: ");
            person.Address = Console.ReadLine();

            Console.Write("New City: ");
            person.City = Console.ReadLine();

            Console.Write("New State: ");
            person.State = Console.ReadLine();

            Console.Write("New Zip: ");
            person.Zip = Console.ReadLine();

            Console.Write("New Phone: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("New Email: ");
            person.Email = Console.ReadLine();

            Console.WriteLine("Person updated successfully!");
        }

        public List<Person> GetAllPersons()
        {
            return persons;
        }
    }
}
