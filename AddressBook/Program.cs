using System;

namespace AddressBook
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookMenu menu = new AddressBookMenu();
            menu.Start();
        }
    }
}
