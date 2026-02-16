
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
        }

        public List<Person> GetAllPersons()
        {
            return persons;
        }
    }
}
