using System;

namespace AddressBook
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Person(string firstName, string lastName, string city, string state)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            State = state;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, City: {City}, State: {State}";
        }

      
        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase) &&
                       LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode() => (FirstName + LastName).ToLower().GetHashCode();
    }
}