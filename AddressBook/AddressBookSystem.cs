using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    public class AddressBookSystem
    {
        private List<Person> contacts = new List<Person>();

        public void AddPerson(Person person)
        {
           
            if (contacts.Any(c => c.Equals(person)))
            {
                Console.WriteLine("Error: A person with this name already exists.");
                return;
            }
            contacts.Add(person);
            Console.WriteLine("Contact added successfully!");
        }

        public void DisplayAll()
        {
            
            foreach (var contact in contacts.OrderBy(c => c.FirstName))
            {
                Console.WriteLine(contact.ToString());
            }
        }

        public void SearchByCity(string city)
        {
           
            var results = contacts.Where(c => c.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
            if (results.Any())
                results.ForEach(r => Console.WriteLine(r));
            else
                Console.WriteLine("No contacts found in that city.");
        }

        public void DeletePerson(string firstName)
        {
            var person = contacts.FirstOrDefault(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
            if (person != null)
            {
                contacts.Remove(person);
                Console.WriteLine("Contact deleted.");
            }
        }
    }
}