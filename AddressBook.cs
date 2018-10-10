using System;
using System.Collections.Generic;

namespace try_catch
{
    public class AddressBook
    {
        Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            try
            {
                addressBook.Add(contact.Email, contact);
            } 
            catch(ArgumentException)
            {
                Console.WriteLine ("----------------------------");
                Console.WriteLine("That precedence has already been set");
            }
        }

        public Contact GetByEmail(string email)
        {
            return addressBook[email];
        }
    }
}