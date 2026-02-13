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

    public void EditPerson()
    {
        Console.Write("Enter First Name of person to edit: ");
        string name = Console.ReadLine();

        bool found = false;

        foreach (var person in  persons)
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
        Console.WriteLine("Welcome to Address Book Program");

        AddressBook adressbook = new AddressBook();

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
        
        adressbook.AddPerson(person);
        adressbook.EditPerson();
        adressbook.DisplayAll();
        
        Console.Write("Press any key to exit");
        Console.ReadKey();

    }
}