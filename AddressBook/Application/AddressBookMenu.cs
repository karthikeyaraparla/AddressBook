using System;
using AddressBook.Core;
using AddressBook.Models;

namespace AddressBook
{
    public class AddressBookMenu
    {
        private AddressBookService service = new AddressBookService();

        public void Start()
        {
            Person p = new Person();

            Console.Write("First Name: ");
            p.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            p.LastName = Console.ReadLine();
            Console.Write("Address: ");
            p.Address = Console.ReadLine();
            Console.Write("City: ");
            p.City = Console.ReadLine();
            Console.Write("State: ");
            p.State = Console.ReadLine();
            Console.Write("Zip: ");
            p.Zip = Console.ReadLine();
            Console.Write("Phone: ");
            p.PhoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            p.Email = Console.ReadLine();

            service.AddPerson(p);
            Console.WriteLine("Person added successfully!");
        }
    }
}
