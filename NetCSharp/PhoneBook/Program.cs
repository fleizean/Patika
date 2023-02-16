using System;

namespace ExamplePhonebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Contact contact = new Contact();
            Phone pbook = new Phone();
            Menu(pbook, contact);
        }

        public static void Menu(Phone pbook, Contact contact)
        {
            string asciitext = """
            ██████  ██   ██  ██████  ███    ██ ███████ ██████   ██████   ██████  ██   ██ 
            ██   ██ ██   ██ ██    ██ ████   ██ ██      ██   ██ ██    ██ ██    ██ ██  ██  
            ██████  ███████ ██    ██ ██ ██  ██ █████   ██████  ██    ██ ██    ██ █████   
            ██      ██   ██ ██    ██ ██  ██ ██ ██      ██   ██ ██    ██ ██    ██ ██  ██  
            ██      ██   ██  ██████  ██   ████ ███████ ██████   ██████   ██████  ██   ██ 
                                                                                         
                                                                                         
            Please choose the operation you want to perform
            """;
            string choosemenu = """
            *******************************************
            (1) Create a new contact
            (2) Delete existing contact
            (3) Update existing contact
            (4) List the contacs
            (5) Search in the PhoneBook
            (0) Exit
            """;
            while(true)
            {
                Console.WriteLine(asciitext);
                Console.WriteLine(choosemenu);
                Console.Write("Your input: ");
                string input = Console.ReadLine().Trim();

                switch(input)
                {
                    case "1":
                        contact.AddContact();
                        break;
                    case "2":
                        contact.RemovePhone();
                        break;
                    case "3":
                        contact.UpdatePhone();
                        break;
                    case "4":
                        contact.ListContact();
                        break;
                    case "5":
                        contact.SearchContact();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid numeric!");
                        break;
                }
            }

        }
    }
}