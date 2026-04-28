using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookSystem myBook = new AddressBookSystem();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Address Book Menu ---");
                Console.WriteLine("1. Add Contact\n2. Display All (Sorted)\n3. Search by City\n4. Delete Contact\n5. Exit");
                Console.Write("Enter Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("First Name: "); string fn = Console.ReadLine();
                        Console.Write("Last Name: "); string ln = Console.ReadLine();
                        Console.Write("City: "); string city = Console.ReadLine();
                        Console.Write("State: "); string state = Console.ReadLine();
                        myBook.AddPerson(new Person(fn, ln, city, state));
                        break;
                    case "2":
                        myBook.DisplayAll();
                        break;
                    case "3":
                        Console.Write("Enter City: ");
                        myBook.SearchByCity(Console.ReadLine());
                        break;
                    case "4":
                        Console.Write("Enter First Name to Delete: ");
                        myBook.DeletePerson(Console.ReadLine());
                        break;
                    case "5":
                        exit = true;
                        break;
                }
            }
        }
    }
}