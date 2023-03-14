using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook
    {
        private List<ContactData> contacts {  get; set; }

        private void DisplayContactDetails(ContactData contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.PhoneNumber}");
        }

        private void DisplayContactDetails(List<ContactData> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }


        public void AddContact(ContactData contact)//adding contact to contact list
        {
            contacts.Add(contact);
        }

        public void DisplayContact(string phoneNumber)
        {
            var contact = contacts.FirstOrDefault(c => c.PhoneNumber == phoneNumber);
            if (contact == null)
                Console.WriteLine("Contact not found");
            else
                DisplayContactDetails(contact);
        }


        public void DisplayAll()
        {
            DisplayContactDetails(contacts);
        }
        
        
        public void FindContact(string search)
        {
            var martchingContacts = contacts.Where(c => c.Name.Contains(search)).ToList();

            foreach (var contact in martchingContacts)

            DisplayContactDetails(martchingContacts);
             
        }


    }
}
