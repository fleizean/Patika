using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePhonebook
{
    public class Phone
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _phoneNum { get; set; }
    }

    public class Contact
    {
        List<Phone> pbook = new List<Phone>();

        public void AddContact()
        {
            Phone phone = new Phone();
            Console.Write("Please enter a name: ");
            phone._firstName = Console.ReadLine();
            Console.Write("Please enter a surname: ");
            phone._lastName = Console.ReadLine();
            Console.Write("Please enter a phone num: ");
            phone._phoneNum = Console.ReadLine();
            pbook.Add(phone);
            Console.WriteLine("New number added successfully.");
            Thread.Sleep(1000);
            Console.Clear();
            return;
        }
        
        public void RemovePhone()
        {
            Console.Write("Please enter the name or surname of the contact you want to delete the number of: ");
            var input = Console.ReadLine();
            Phone p = new Phone();
            foreach(Phone item in pbook)
            {
                if (item._firstName.ToLower() == input.ToLower() || item._lastName == input.ToLower())
                    p = item;
            }
            if (p._firstName == null || p._lastName == null)
            {
                Console.WriteLine("I couldn't find such a person.");
                Console.WriteLine("To end the update: (1)\r\nTo retry: (2)");
                string choiceAction = Console.ReadLine();
                if (choiceAction == "1")
                {
                    Console.WriteLine("Returning to the main menu.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if (choiceAction == "2")
                {
                    RemovePhone();
                }
                else
                {
                    Console.WriteLine("Wrong choose, returning to the main menu.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"Do you confirm to delete the contact {p._firstName} {p._lastName} ?(y/n)");
                string userAction = Console.ReadLine().ToLower();
                if(userAction == "y")
                {
                    pbook.Remove(p);
                    Console.WriteLine("Deletion process has been completed successfully.");
                    Thread.Sleep(1000);
                }
                else if(userAction == "n")
                {
                    Console.WriteLine("Deletion process has been cancelled.");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Wrong choose, returning to the main menu.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
        public void UpdatePhone()
        {
            Console.Write("Please enter the name or surname of the contact whose phone number you want to update: ");
            var input = Console.ReadLine();
            Phone p = new Phone();
            foreach(Phone item in pbook)
            {
                if (item._firstName.ToLower() == input.ToLower() || item._lastName == input.ToLower())
                    p = item;
            }
            if (p._firstName == null || p._lastName == null)
            {
                Console.WriteLine("I couldn't find such a person.");
                Console.WriteLine("To end the update: (1)\r\nTo retry: (2)");
                string choiceAction = Console.ReadLine();
                if (choiceAction == "1")
                {
                    Console.WriteLine("Returning to the main menu.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if (choiceAction == "2")
                {
                    UpdatePhone();
                }
                else
                {
                    Console.WriteLine("Wrong choose, returning to the main menu.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"Do you want to update the contact for {p._firstName} {p._lastName} (y/n)");
                string userAction = Console.ReadLine().ToLower();   
                if (userAction == "y")
                {
                    Console.Write("Please enter a new name: ");
                    p._firstName = Console.ReadLine();
                    Console.Write("Please enter a new surname: ");
                    p._lastName = Console.ReadLine();
                    Console.Write("Please enter a new phone num: ");
                    p._phoneNum = Console.ReadLine();
                    Console.WriteLine("Update process has been completed successfully.");
                    Thread.Sleep(1000);
                }
                else if (userAction == "n")
                {
                    Console.WriteLine(value: "Updating process has been cancelled.");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Wrong choose, returning to the main menu.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
        public void ListContact()
        {
            Console.Clear();
            Console.WriteLine("*********** PhoneBook ***********");
            foreach (Phone item in pbook)
            {
                Console.WriteLine($"First Name: {item._firstName}\r\nLast Name: {item._lastName}\r\nPhone Num: {item._phoneNum}\r\n-------------");
            }
            Console.WriteLine("Press any key to return to the main menu.");
            string notneeded = Console.ReadLine();
        }

        public void SearchContact()
        {
            Console.Clear();
            Console.WriteLine("Please select the type of search you want to perform.");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("To search by name or surname: (1)\r\nTo search by phone number: (2)\r\n Your choice: ");
            string chooseAction = Console.ReadLine();
            if(chooseAction == "1")
            {
                Console.Write("Please enter the first or last name of the person you want to search for: ");
                var input = Console.ReadLine();
                Phone p = new Phone();
                foreach (Phone item in pbook)
                {
                    if (item._firstName.ToLower() == input.ToLower() || item._lastName == input.ToLower())
                        p = item;
                }
                if(p._firstName == null || p._lastName == null)
                {
                    Console.WriteLine("I couldn't find such a person.");
                    Console.WriteLine("To end the search: (1)\r\nTo retry: (2)");
                    string userAction = Console.ReadLine();
                    if (userAction == "1")
                    {
                        Console.WriteLine("Returning to the main menu.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else if (userAction == "2")
                    {
                        SearchContact();
                    }
                    else
                    {
                        Console.WriteLine("Wrong choose, returning to the main menu.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("*********** Search Results  ***********");
                    Console.WriteLine($"First Name: {p._firstName}\r\nLast Name: {p._lastName}\r\nPhone Num: {p._phoneNum}\r\n-------------");
                }
            }
            else if(chooseAction == "2")
            {
                Console.Write("Please enter phone number you want to search for: ");
                var input = Console.ReadLine();
                Phone p = new Phone();
                foreach (Phone item in pbook)
                {
                    if (item._phoneNum == input)
                        p = item;
                }
                if(p._phoneNum == null)
                {
                    Console.WriteLine("I couldn't find such a person.");
                    Console.WriteLine("To end the search: (1)\r\nTo retry: (2)");
                    string userAction = Console.ReadLine();
                    if (userAction == "1")
                    {
                        Console.WriteLine("Returning to the main menu.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else if (userAction == "2")
                    {
                        SearchContact();
                    }
                    else
                    {
                        Console.WriteLine("Wrong choose, returning to the main menu.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("*********** Search Results  ***********");
                    Console.WriteLine($"First Name: {p._firstName}\r\nLast Name: {p._lastName}\r\nPhone Num: {p._phoneNum}\r\n-------------");
                }
            }
            else
            {
                Console.WriteLine("Wrong choose, returning to the main menu.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}