using System;
using System.Collections.Generic;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}

class AddressBook
{
    List<Person> persons = new List<Person>();

    public void AddPerson(Person p)
    {
        persons.Add(p);
        Console.WriteLine("Person added successfully");
    }

    public void DeletePerson()
    {
        Console.WriteLine("Enter the first name of the person you want to delete:");
        string name = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < persons.Count; i++)
        {
            if (persons[i].FirstName == name)
            {
                persons.RemoveAt(i);
                Console.WriteLine("Person deleted successfully!");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Person not found");
        }
    }

    public void EditPerson()
    {
        Console.Write("Enter First Name of person to edit: ");
        string name = Console.ReadLine();

        bool found = false;

        foreach (var person in persons)
        {
            if (person.FirstName == name)
            {
                Console.WriteLine("Person found. Enter new details: ");

                Console.Write("New Address: ");
                person.Address = Console.ReadLine();

                Console.Write("New City: ");
                person.City = Console.ReadLine();

                Console.Write("New State: ");
                person.State = Console.ReadLine();

                Console.Write("New Zip Code: ");
                person.Zip = Console.ReadLine();

                Console.Write("New Email: ");
                person.Email = Console.ReadLine();

                Console.Write("New Phone: ");
                person.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Person updated successfully!");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Person not found");
        }
    }

    public void DisplayAll()
    {
        if (persons.Count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        foreach (var person in persons)
        {
            Console.WriteLine($"{person.FirstName}, {person.LastName}, {person.Address}, {person.City}, {person.State}, {person.Zip}, {person.Email}, {person.PhoneNumber}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program (UC6)");

        Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();
        AddressBook currentBook = null;

        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Create Address Book");
            Console.WriteLine("2. Select Address Book");
            Console.WriteLine("3. Add Person");
            Console.WriteLine("4. Edit Person");
            Console.WriteLine("5. Delete Person");
            Console.WriteLine("6. Display All");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter new Address Book name: ");
                    string bookName = Console.ReadLine();

                    if (addressBooks.ContainsKey(bookName))
                    {
                        Console.WriteLine("Address Book with this name already exists!");
                    }
                    else
                    {
                        addressBooks[bookName] = new AddressBook();
                        Console.WriteLine("Address Book created successfully!");
                    }
                    break;

                case 2:
                    Console.Write("Enter Address Book name to select: ");
                    string selectName = Console.ReadLine();

                    if (addressBooks.ContainsKey(selectName))
                    {
                        currentBook = addressBooks[selectName];
                        Console.WriteLine($"Address Book '{selectName}' selected.");
                    }
                    else
                    {
                        Console.WriteLine("Address Book not found!");
                    }
                    break;

                case 3:
                    if (currentBook == null)
                    {
                        Console.WriteLine("Please select an Address Book first!");
                        break;
                    }

                    char choiceAdd;
                    do
                    {
                        Person person = new Person();

                        Console.Write("First Name: ");
                        person.FirstName = Console.ReadLine();

                        Console.Write("Last Name: ");
                        person.LastName = Console.ReadLine();

                        Console.Write("Address: ");
                        person.Address = Console.ReadLine();

                        Console.Write("City: ");
                        person.City = Console.ReadLine();

                        Console.Write("State: ");
                        person.State = Console.ReadLine();

                        Console.Write("Zip Code: ");
                        person.Zip = Console.ReadLine();

                        Console.Write("Email: ");
                        person.Email = Console.ReadLine();

                        Console.Write("Phone: ");
                        person.PhoneNumber = Console.ReadLine();

                        currentBook.AddPerson(person);

                        Console.Write("Do you want to add another person? (y/n): ");
                        choiceAdd = Console.ReadLine().ToLower()[0];

                    } while (choiceAdd == 'y');

                    break;

                case 4:
                    if (currentBook == null)
                    {
                        Console.WriteLine("Please select an Address Book first!");
                        break;
                    }
                    currentBook.EditPerson();
                    break;

                case 5:
                    if (currentBook == null)
                    {
                        Console.WriteLine("Please select an Address Book first!");
                        break;
                    }
                    currentBook.DeletePerson();
                    break;

                case 6:
                    if (currentBook == null)
                    {
                        Console.WriteLine("Please select an Address Book first!");
                        break;
                    }
                    currentBook.DisplayAll();
                    break;

                case 7:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
