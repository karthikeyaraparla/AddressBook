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
                Console.WriteLine("4. View by City");
                Console.WriteLine("5. View by State");
                Console.WriteLine("6. Display All");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: CreateBook(); break;
                    case 2: SelectBook(); break;
                    case 3: if (CheckBook()) AddPerson(); break;
                    case 4: if (CheckBook()) ViewByCity(); break;
                    case 5: if (CheckBook()) ViewByState(); break;
                    case 6: if (CheckBook()) currentBook.DisplayAll(); break;
                    case 7: return;
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
                Program.Books[name] = new AddressBookService();
        }

        private void SelectBook()
        {
            Console.Write("Enter Address Book name: ");
            string name = Console.ReadLine();
            if (Program.Books.ContainsKey(name))
                currentBook = Program.Books[name];
        }

        private void AddPerson()
        {
            Person p = new Person();
            Console.Write("First Name: "); p.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");  p.LastName = Console.ReadLine();
            Console.Write("City: ");       p.City = Console.ReadLine();
            Console.Write("State: ");      p.State = Console.ReadLine();
            currentBook.AddPerson(p);
        }

        private void ViewByCity()
        {
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            var list = currentBook.ViewByCity(city);
            foreach (var p in list)
                Console.WriteLine($"{p.FirstName} {p.LastName}, {p.City}, {p.State}");
        }

        private void ViewByState()
        {
            Console.Write("Enter State: ");
            string state = Console.ReadLine();
            var list = currentBook.ViewByState(state);
            foreach (var p in list)
                Console.WriteLine($"{p.FirstName} {p.LastName}, {p.City}, {p.State}");
        }
    }
}
