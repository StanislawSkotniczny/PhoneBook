using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PhoneBook");
            Console.WriteLine("Select option");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact number");
            Console.WriteLine("3 Show all contacts");
            Console.WriteLine("4 Search contacts by name");
            Console.WriteLine("Press x to exit");

            var userInput = Console.ReadLine();
            
            var phoneBook = new PhoneBook();

            while(true) // program stops breaking after doing one option
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number");
                        var number = Console.ReadLine();

                        var newContact = new ContactData(name, number);
                        phoneBook.AddContact(newContact);

                        break;

                    case "2":
                        Console.WriteLine("Search contact by number:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;

                    case "3":
                        phoneBook.DisplayAll();
                        break;

                    case "4":
                        Console.WriteLine("Search contact by name");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.FindContact(searchPhrase);
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Select valid option");
                        break;
                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
           

        }



    }

}