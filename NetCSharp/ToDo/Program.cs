using System;

namespace ToDoApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Methods m = new Methods();
            string choiceMessage = """
            Please choose an operation you want to perform
            *******************************************
            (1) List Boards
            (2) Add Card to Board
            (3) Delete Card from Board
            (4) Move Card
            (5) Exit
            """;
            Console.WriteLine(choiceMessage);
            Console.Write("Your choice: ");
            string userAction = Console.ReadLine();

            switch(userAction)
            {
                case "1":
                    m.ListCards();
                    break;
                case "2":
                    m.AddingCard();
                    break;
                case "3":
                    m.DeleteCard();
                    break;
                case "4":
                    m.MoveCard();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong choice.");
                    break;
            }
        }
    }
}