using System;
using AddressBook.Core;
using AddressBook.Models;

namespace AddressBook
{
    public class AddressBookMenu
    {
        private AddressBookService currentBook = null;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n1. Create Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Add Person");
                Console.WriteLine("4. Display All");
                Console.WriteLine("5. Sort By Name");
                Console.WriteLine("6. Sort By City");
                Console.WriteLine("7. Sort By State");
                Console.WriteLine("8. Sort By Zip");
                Console.WriteLine("9. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: CreateBook(); break;
                    case 2: SelectBook(); break;
                    case 3: if (CheckBook()) AddPerson(); break;
                    case 4: if (CheckBook()) currentBook.DisplayAll(); break;
                    case 5: if (CheckBook()) DisplayList(currentBook.SortByName()); break;
                    case 6: if (CheckBook()) DisplayList(currentBook.SortByCity()); break;
                    case 7: if (CheckBook()) DisplayList(currentBook.SortByState()); break;
                    case 8: if (CheckBook()) DisplayList(currentBook.SortByZip()); break;
                    case 9: return;
                }
            }
        }

        private bool CheckBook()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Select an Address Book first!");
                return false;
            }
            return true;
        }

        private void CreateBook()
        {
            Console.Write("Enter Address Book name: ");
            string name = Console.ReadLine();

            if (!Program.Books.ContainsKey(name))
            {
                Program.Books[name] = new AddressBookService();
                Console.WriteLine("Address Book created!");
            }
            else
            {
                Console.WriteLine("Address Book already exists!");
            }
        }

        private void SelectBook()
        {
            Console.Write("Enter Address Book name: ");
            string name = Console.ReadLine();

            if (Program.Books.ContainsKey(name))
            {
                currentBook = Program.Books[name];
                Console.WriteLine("Address Book selected!");
            }
            else
            {
                Console.WriteLine("Address Book not found!");
            }
        }

        private void AddPerson()
        {
            Person p = new Person();

            Console.Write("First Name: ");
            p.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            p.LastName = Console.ReadLine();
            Console.Write("City: ");
            p.City = Console.ReadLine();
            Console.Write("State: ");
            p.State = Console.ReadLine();
            Console.Write("Zip: ");
            p.Zip = Console.ReadLine();
            Console.Write("Email: ");
            p.Email = Console.ReadLine();
            Console.Write("Phone: ");
            p.PhoneNumber = Console.ReadLine();

            try
            {
                currentBook.AddPerson(p);
                Console.WriteLine("Person added successfully!");
            }
            catch (DuplicateEmailException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void DisplayList(System.Collections.Generic.List<Person> list)
        {
            foreach (var p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
