using System;
using System.Collections.Generic;

namespace lab3
{
    public class PhoneBook
    {
        private List<Contact> contacts;

        public PhoneBook()
        {
            this.contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            this.contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            this.contacts.Remove(contact);
        }

        public Contact FindContact(string name)
        {
            return this.contacts.Find(contact => contact.Name.Equals(name));
        }

        public List<Contact> GetContacts()
        {
            return this.contacts;
        }

        public int CountContacts()
        {
            return this.contacts.Count;
        }
    }
}
