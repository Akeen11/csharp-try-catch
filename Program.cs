using System;
using System.Collections.Generic;

namespace try_catch {
    class Program {
        /*
            1. Add the required classes to make the following code compile.
            HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.

            2. Run the program and observe the exception.

            3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
                Print meaningful error messages in the catch blocks.
        */

        static void Main (string[] args) {
            // Create a few contacts
            Contact garrett = new Contact () {
                FirstName = "Garrett", LastName = "Kent",
                Email = "garrett.kent@bro.com",
                Address = "100 Bro Ln, Broville, TN 11111"
            };
            Contact keith = new Contact () {
                FirstName = "Keith", LastName = "Rutkowski",
                Email = "keith.rutkowski@bitch.com",
                Address = "666 Bitch St, Bitchville, TN 00000"
            };
            Contact jon = new Contact () {
                FirstName = "Jon", LastName = "Riley",
                Email = "jon.riley@squad.com",
                Address = "100 Precedence Way, Squadville, TN 11111"
            };

            // Create an AddressBook and add some contacts to it
            AddressBook addressBook = new AddressBook ();
            addressBook.AddContact (garrett);
            addressBook.AddContact (keith);
            addressBook.AddContact (jon);

            // Try to addd a contact a second time
            addressBook.AddContact (keith);

            // Create a list of emails that match our Contacts
            List<string> emails = new List<string> () {
                "garrett.kent@bro.com",
                "jon.riley@squad.com",
                "keith.rutkowski@bitch.com",
            };

            // Insert an email that does NOT match a Contact
            emails.Insert (1, "not.in.addressbook@email.com");

            //  Search the AddressBook by email and print the information about each Contact
            foreach (string email in emails) {
                try
                {
                Contact contact = addressBook.GetByEmail (email);
                Console.WriteLine ("----------------------------");
                Console.WriteLine ($"Name: {contact.FullName}");
                Console.WriteLine ($"Email: {contact.Email}");
                Console.WriteLine ($"Address: {contact.Address}");
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine ("----------------------------");
                    Console.WriteLine("We live in a society!");
                }
            }
        }
    }
}
