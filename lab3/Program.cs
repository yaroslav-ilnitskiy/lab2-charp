using System;

namespace lab3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Phone book");

            PhoneBook phoneBook = new PhoneBook();

            while (true)
            {
                Console.WriteLine("Enter command, a - show all contacts, n - add new contact, r - remove contact");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "a":
                        WriteContacts(phoneBook);
                        break;
                    case "n":
                        AddContact(phoneBook);
                        break;
                    case "r":
                        RemoveContact(phoneBook);
                        break;
                }
            }
        }

        static void WriteContacts(PhoneBook phoneBook)
        {
            if (phoneBook.CountContacts() == 0)
            {
                Console.WriteLine("List is empty");
                return;
            }

            foreach (Contact contact in phoneBook.GetContacts())
            {
                Console.WriteLine($"Name: {contact.Name} PersonalPhone: {contact.PersonalPhone} Phone {contact.Phone} Description {contact.Description}");
            }
        }

        static void AddContact(PhoneBook phoneBook)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Contact contact = new Contact(name);

            Console.WriteLine("Enter PersonalPhone");
            contact.PersonalPhone = Console.ReadLine();

            Console.WriteLine("Enter Phone");
            contact.Phone = Console.ReadLine();

            Console.WriteLine("Enter Description");
            contact.Description = Console.ReadLine();

            phoneBook.AddContact(contact);

            Console.WriteLine("Contact successfully added");
        }

        static void RemoveContact(PhoneBook phoneBook)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Contact contact = phoneBook.FindContact(name);

            if (contact == null)
            {
                return;
            }

            phoneBook.RemoveContact(contact);
        }
    }
}
