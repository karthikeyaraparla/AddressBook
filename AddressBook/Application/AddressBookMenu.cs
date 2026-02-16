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
            while (true)
            {
                Console.WriteLine("\n1. Add Person");
                Console.WriteLine("2. Edit Person");
                Console.WriteLine("3. Delete Person");
                Console.WriteLine("4. Display All");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddMultiplePersons();
                        break;
                    case 2:
                        Console.Write("Enter First Name to edit: ");
                        service.EditPerson(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Enter First Name to delete: ");
                        service.DeletePerson(Console.ReadLine());
                        break;
                    case 4:
                        service.DisplayAll();
                        break;
                    case 5:
                        return;
                }
            }
        }

        private void AddMultiplePersons()
        {
            char ch;
            do
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

                Console.Write("Add another person? (y/n): ");
                ch = Console.ReadLine().ToLower()[0];

            } while (ch == 'y');
        }
    }
}
