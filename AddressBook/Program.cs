using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        public static Dictionary<string, Core.AddressBookService> Books 
            = new Dictionary<string, Core.AddressBookService>();

        static void Main()
        {
            AddressBookMenu menu = new AddressBookMenu();
            menu.Start();
        }
    }
}
