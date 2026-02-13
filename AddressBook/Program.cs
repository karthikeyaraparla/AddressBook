using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
        Console.WriteLine("Enter the person name You want to delete");
        string name = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < persons.Count; i++)
        {
            if (persons[i].FirstName == name)
            {
                persons.RemoveAt(i);
                Console.WriteLine("Person deleted Successfully!");
                found = true;
                break;
            }
        }
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

        AddressBook addressbook = new AddressBook();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. Edit Person");
            Console.WriteLine("3. Delete Person");
            Console.WriteLine("4. Display All");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
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

                    addressbook.AddPerson(person);
                    break;

                case 2:
                    addressbook.EditPerson();
                    break;

                case 3:
                    addressbook.DeletePerson();
                    break;

                case 4:
                    addressbook.DisplayAll();
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}