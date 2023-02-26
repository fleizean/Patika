using System;
using Spectre.Console;

namespace votingapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContextUser ctxuser = new ContextUser();
            Category[] categories = new Category[3];

            categories[0] = new Category();
            categories[0]._ID = 1;
            categories[0]._Tittle = "Action";
            categories[0]._VoteCount = 0;
            categories[0]._LastVoter = "Enes";

            categories[1] = new Category();
            categories[1]._ID = 2;
            categories[1]._Tittle = "SC-FI";
            categories[1]._VoteCount = 0;
            categories[1]._LastVoter = "Vedat";

            categories[2] = new Category();
            categories[2]._ID = 3;
            categories[2]._Tittle = "Comedy";
            categories[2]._VoteCount = 0;
            categories[2]._LastVoter = "Devrim";

            string selection;
            selection = WelcomePrint();
            if(selection == "Login")
            {
                var username = AnsiConsole.Ask<string>("[green]Username[/]:");
                var password = AnsiConsole.Prompt(
                    new TextPrompt<string>("[green]Password[/]:")
                        .PromptStyle("red")
                        .Secret('-'));

                bool loginAction = ctxuser.ContextControl(username, password);
                if (loginAction == true)
                {
                    AnsiConsole.Write(new Markup("[green]Login[/] [green]successful![/]"));
                    Console.WriteLine();
                    foreach (var item in categories)
                    {
                        Console.WriteLine(item._ID + " - " + item._Tittle + " = ");
                        var vote = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                                .Title("[green]Vote me![/]?")
                                .PageSize(12)
                                .MoreChoicesText("[grey](Move up and down)[/]")
                                .AddChoices(new[] {
                                    "0", "1", "2", 
                                    "3", "4", "5",
                                    "6", "7", "8",
                                    "9", "10"
                        }));
                        item._VoteCount = Convert.ToInt32(vote);
                        item._LastVoter = username;
                    }
                    Console.WriteLine("Voting Results:");
                    foreach(var item in categories)
                    {
                        Console.Write(item._ID + " - " + item._Tittle + " = ");
                        for (int i = 0; i < item._VoteCount; i++)
                        {
                            Console.Write("#");
                        }
                        for (int i = 0; i < 10 - item._VoteCount; i++)
                        {
                            Console.Write("-");
                        }
                        Console.Write(" % " + item._VoteCount * 10 + "\n");
                    }
                }
                else if(loginAction == false)
                {
                    Console.WriteLine("Wrong username or wrong password!");
                }
            }
            else if(selection == "Register")
            {
                User user = new User();
                Console.Clear();
                Console.WriteLine("Welcome to Register Area!");

                var username = AnsiConsole.Ask<string>("[green]Username[/]:");
                user._UserName = username;
                var password = AnsiConsole.Prompt(
                    new TextPrompt<string>("[green]Password[/]:")
                        .PromptStyle("red")
                        .Secret('-'));
                user._Password = password;
                var firstname = AnsiConsole.Ask<string>("[green]Firstname[/]:");
                user._FirstName = firstname;
                var lastname = AnsiConsole.Ask<string>("[green]Lastname[/]:");
                user._LastName = lastname;
                user._UserCreationDate = DateTime.Now;

                bool action = ctxuser.AddUser(user);
                if(action == true)
                    Console.WriteLine("Account created successfully!");
                else
                    Console.WriteLine("There is a similar username in the system!");
            }
            else if(selection == "Exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong Input!");
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
        static public string WelcomePrint()
        {
            string welcomeprint = """
             _    __      __  _                ___    ____  ____ 
            | |  / /___  / /_(_)___  ____ _   /   |  / __ \/ __ \
            | | / / __ \/ __/ / __ \/ __ `/  / /| | / /_/ / /_/ /
            | |/ / /_/ / /_/ / / / / /_/ /  / ___ |/ ____/ ____/ 
            |___/\____/\__/_/_/ /_/\__, /  /_/  |_/_/   /_/      
                                  /____/                         
            """;
            Console.WriteLine(welcomeprint);
            var prompt = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Welcome, Firstly you must login.")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down)[/]")
                    .AddChoices(new[] {
                    "Login", "Register", "Exit"
                }));
            return (prompt);
        }
    }
}