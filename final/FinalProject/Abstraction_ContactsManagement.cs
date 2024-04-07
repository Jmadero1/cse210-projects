using System;
using System.Collections.Generic;

namespace Abstraction_ContactsManagement
{
    //Class that represents a contact
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    // Contact Management Class
    public class ContactManager
    {
        private List<Contact> contacts;

        public ContactManager()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DisplayContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Name}, Phone: {contact.PhoneNumber}, Email: {contact.Email}");
            }
        }
    }
}
