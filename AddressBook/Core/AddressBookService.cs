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
            persons.Add(person);
            Console.WriteLine("Person added successfully!");
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

        public void DeletePerson(string firstName)
        {
            Person person = persons.Find(p => p.FirstName == firstName);
            if (person == null)
            {
                Console.WriteLine("Person not found!");
                return;
            }

            persons.Remove(person);
            Console.WriteLine("Person deleted successfully!");
        }

        public void DisplayAll()
        {
            if (persons.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            foreach (var p in persons)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}, {p.City}, {p.State}, {p.Zip}, {p.Email}, {p.PhoneNumber}");
            }
        }
    }
}
