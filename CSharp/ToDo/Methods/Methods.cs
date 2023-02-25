using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ToDoApplication
{
    public class Methods
    {
        Card newCard = new Card();
        public void AddingCard()
        {
            string addingcardmenu = """
            Adding Card Area
            *****************************
            """;
            Console.WriteLine(addingcardmenu);
            Console.Write("Enter Title: ");
            newCard.Head = Console.ReadLine();
            
            Console.Write("Enter Content: ");
            newCard.Content = Console.ReadLine();

            Console.Write("Choose Person: ");
            newCard.Person = Console.ReadLine();

            Console.Write("Please select your status (1) To-Do (2) In Progress (3) Done: ");
            int choosingtodo = int.Parse(Console.ReadLine());
            if (choosingtodo == 1)
                newCard.Status = "ToDo";    
            else if (choosingtodo == 2)
                newCard.Status = "InProgress";
            else if (choosingtodo == 3)
                newCard.Status = "Done";
            else
                Console.WriteLine("Wrong choose.");

            Console.Write("Select Size -> XS(1),S(2),M(3),L(4),XL(5): ");
            int choosingSize = int.Parse(Console.ReadLine());
            if(choosingSize == 1)
                newCard.Size = "XS";
            else if(choosingSize == 2)
                newCard.Size = "S";
            else if(choosingSize == 3)
                newCard.Size = "M";
            else if(choosingSize == 4)
                newCard.Size = "L";
            else if(choosingSize == 5)
                newCard.Size = "XL";
            CheckID();
        }

        public void DeleteCard()
        {
            Console.WriteLine("First, you need to select the card you want to delete.");
            Console.Write("Please enter the card title: ");
            string? chooseAction = Console.ReadLine();

            Database person = new Database();
            var item = Database.Card.FirstOrDefault(x => x.Head == chooseAction);
            if (item != null)
            {
                Database.Card.Remove(item);
                Console.WriteLine("Delete action success.");
            }
            else
            {
                Console.WriteLine("Sorry, no card found that matches your criteria.");
            }
        }

        private static Board _Boards;
        public void ListCards()
        {
            Console.Clear();
            LineTheBoard();
            DisplayTheCard("TODO Line", _Boards.ToDo);
            DisplayTheCard("IN PROGRESS Line", _Boards.Inprogress);
            DisplayTheCard("DONE Line", _Boards.Done);
        }
        
        public void MoveCard()
        {
            Console.WriteLine("You first need to select the card you want to move.");
            Console.Write("Please enter the title of the card: ");
            string chooseAction = Console.ReadLine();
            var item = Database.Card.FirstOrDefault(person => person.Head == chooseAction);
            if(item == null)
            {
                Console.WriteLine("No card matching your criteria was found on the board.");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Found Card Information:");
                Console.WriteLine("***********************");
                Console.WriteLine("Head    : {0}", item.Head);
                Console.WriteLine("Content : {0}", item.Content);
                Console.WriteLine("Person  : {0}", item.Person);
                Console.WriteLine("Size    : {0}", item.Size);
                Console.WriteLine("Line    : {0}", item.Status);
                Console.WriteLine();
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                Console.WriteLine("Please select the Line to move the card: ");
                int choiceStatus = int.Parse(Console.ReadLine());
                if (choiceStatus == 1)
                    item.Status = "ToDo";
                else if (choiceStatus == 2)
                    item.Status = "InProgress";
                else if (choiceStatus == 3)
                    item.Status = "Done";
                else
                    Console.WriteLine("Wrong choose");
                ListCards();
            }
        }

        // Helper Func
        public void CheckID()
        {
            Database check = new Database();
            Console.Write("Write a id num: ");
            int id = int.Parse(Console.ReadLine());
            var item = Database.Person.FirstOrDefault(x => x.ID == id);
            if(item != null)
            {
                Database.Card.Add(newCard);
                Console.WriteLine("A new card has been created by {0}.", item.Name);
            }
            else
            {
                Console.WriteLine("Wrong choose.");
                Thread.Sleep(2000);
            }
        }
        public void DisplayTheCard(string boardType, List<Card>? listName)
        {
            Console.WriteLine(boardType);
            Console.WriteLine("****************************");
            foreach (var item in listName)
            {
                Console.WriteLine("Head      : {0}", item.Head);
                Console.WriteLine("Content      : {0}", item.Content);
                Console.WriteLine("Person : {0}", item.Person);
                Console.WriteLine("Size    : {0}", item.Size);
                Console.WriteLine("-");
            }
        }
        public void LineTheBoard()
        {
            var toDo = Database.Card.Where(x => x.Status == "ToDo").ToList();
            var inProgress = Database.Card.Where(x => x.Status == "InProgress").ToList();
            var done = Database.Card.Where(x => x.Status == "Done").ToList();

            _Boards = new Board();
            _Boards.ToDo = toDo;
            _Boards.Inprogress = inProgress;
            _Boards.Done = done;
        }
    }
}