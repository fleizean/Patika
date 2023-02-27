using System;
using Spectre.Console;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace atmapp
{
    public class Program
    {
        public static string file = "Transaction Log\n\nLog ID - Log User ID - Title - IP - Date\n";
        public static int id = 0;
        public static void Main(string[] args)
        {
            Controller control = new Controller();
            Memory memory = new Memory();
            bool result = false;
            int price, i = 0;
            string prompt = WelcomePrint();
            
            if(prompt == "Login")
            {
                var userid = "0";
                do
                {
                    userid = AnsiConsole.Ask<string>("[green]User ID[/]:");
                    result = int.TryParse(userid, out price);
                }
                while(result != true);
                var password = AnsiConsole.Prompt(
                    new TextPrompt<string>("[green]Password[/]:")
                        .PromptStyle("red")
                        .Secret('-'));
                bool loginAction = control.UserController(Convert.ToInt32(userid), password);
                if (loginAction == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Login successful!");
                    Console.ResetColor(); 
                    MakeLog(Convert.ToInt32(userid), "Succesful Login");
                    Thread.Sleep(2000);
                    Console.Clear();
                    User? user = memory.GetByUser(Convert.ToInt32(userid));
                    while(true)
                    {
                        if(i != 0)
                            Console.Clear();
                        i++;
                        string promptAction = Menu();
                        switch(promptAction)    
                        {
                            case "Withdraw Money":
                                Console.Clear();
                                var money = AnsiConsole.Ask<int>("[green]Enter the amount you want to withdraw[/]:");   
                                user._Money -= money;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Successful withdrawal, your current balance is "+ user._Money);
                                Console.ResetColor();
                                MakeLog(Convert.ToInt32(userid), "Succesful Withdraw");
                                Thread.Sleep(2000);
                                break;
                            case "Deposit Money":
                                Console.Clear();
                                var deposit = 0;
                                do
                                {
                                    deposit = AnsiConsole.Ask<int>("[green]Enter the amount you want to deposit[/]:");     
                                    user._Money += deposit;
                                    MakeLog(Convert.ToInt32(userid), "Failed Deposit");
                                }
                                while(deposit <= 0);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Successful deposit, your current balance is "+ user._Money);
                                Console.ResetColor();
                                MakeLog(Convert.ToInt32(userid), "Succesful Deposit");
                                Thread.Sleep(2000);
                                break;
                            case "Make a Payment":
                                Console.Clear();
                                string paymentAction = PaymentMenu();
                                if(paymentAction == "Taxes")
                                {
                                    Console.Clear();
                                    Random random = new Random();
                                    int randomNumber = random.Next(60, 201);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Taxes Payment " + randomNumber + "TL");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    user._Money -= randomNumber;
                                    MakeLog(Convert.ToInt32(userid), "Taxes Payment successful");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Successful taxes payment, your current balance is "+ user._Money);
                                    Console.ResetColor();
                                    Thread.Sleep(2000);
                                }
                                else if(paymentAction == "YKS")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YKS Payment 145TL");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    user._Money -= 145;
                                    MakeLog(Convert.ToInt32(userid), "YKS Payment successful");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Successful YKS payment, your current balance is "+user._Money);
                                    Console.ResetColor();
                                    Thread.Sleep(2000);
                                }
                                break;
                            case "Log Out":
                                Console.Clear();
                                Console.WriteLine("Exiting...");
                                MakeLog(Convert.ToInt32(userid), "Log out");
                                Environment.Exit(0);
                                break;
                            case "End of Day Transaction":
                                Console.Clear();
                                string filePath = @"/Users/fleizean/Desktop/Patika/C# Projects/Hard Level/ATM App/" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                                File.WriteAllText(filePath, file);
                                break;
                            default:
                                Console.WriteLine("Wrong choose exiting...");
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
                else
                {
                    MakeLog(Convert.ToInt32(userid), "Login Fail");
                    Console.WriteLine("Wrong username or password...");
                }
            }
            else if(prompt == "Exit")
            {
                Console.WriteLine("Exiting...");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong answer exiting...");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
        static public string PaymentMenu()
        {
            string welcomeprint = """
                  ___                       ___     
                 /  /\          ___        /__/\    
                /  /::\        /  /\      |  |::\   
               /  /:/\:\      /  /:/      |  |:|:\  
              /  /:/~/::\    /  /:/     __|__|:|\:\ 
             /__/:/ /:/\:\  /  /::\    /__/::::| \:\
             \  \:\/:/__\/ /__/:/\:\   \  \:\~~\__\/
              \  \::/      \__\/  \:\   \  \:\      
               \  \:\           \  \:\   \  \:\     
                \  \:\           \__\/    \  \:\    
                 \__\/                     \__\/    
            """;
            Console.WriteLine(welcomeprint);
            var prompt = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose payment.")
                    .PageSize(3)
                    .MoreChoicesText("[grey](Move up and down)[/]")
                    .AddChoices(new[] {
                    "Taxes", "YKS",
                }));
            return prompt;
        }
        static public void MakeLog(int userid, string title)
        {
            GetLocalIP ip = new GetLocalIP();
            Controller control = new Controller();
            file += String.Format("{0} - {1} - {2} - {3} - {4}\n",id, userid, title, ip.GetLocalIPAddress(), DateTime.Now);
            id++;
        }
        static public string WelcomePrint()
        {
            string welcomeprint = """
                  ___                       ___     
                 /  /\          ___        /__/\    
                /  /::\        /  /\      |  |::\   
               /  /:/\:\      /  /:/      |  |:|:\  
              /  /:/~/::\    /  /:/     __|__|:|\:\ 
             /__/:/ /:/\:\  /  /::\    /__/::::| \:\
             \  \:\/:/__\/ /__/:/\:\   \  \:\~~\__\/
              \  \::/      \__\/  \:\   \  \:\      
               \  \:\           \  \:\   \  \:\     
                \  \:\           \__\/    \  \:\    
                 \__\/                     \__\/    
            """;
            Console.WriteLine(welcomeprint);
            AnsiConsole.Progress()
                .Start(ctx => 
                {
                    // Define tasks
                    var task1 = ctx.AddTask("[green]Localizating[/]");
                    var task2 = ctx.AddTask("[green]Finding database[/]");
                    var task3 = ctx.AddTask("[green]Getting datas[/]");
                    while(!ctx.IsFinished) 
                    {
                        task1.Increment(0.0005);
                        task2.Increment(0.0003);
                        task3.Increment(0.00009);
                    }
                });
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(welcomeprint);
                var prompt = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Welcome, Firstly you must login with your id.")
                    .PageSize(3)
                    .MoreChoicesText("[grey](Move up and down)[/]")
                    .AddChoices(new[] {
                    "Login", "Exit"
                }));
                return prompt;
        }

        static public string Menu()
        {
            string welcomeprint = """
                  ___                       ___     
                 /  /\          ___        /__/\    
                /  /::\        /  /\      |  |::\   
               /  /:/\:\      /  /:/      |  |:|:\  
              /  /:/~/::\    /  /:/     __|__|:|\:\ 
             /__/:/ /:/\:\  /  /::\    /__/::::| \:\
             \  \:\/:/__\/ /__/:/\:\   \  \:\~~\__\/
              \  \::/      \__\/  \:\   \  \:\      
               \  \:\           \  \:\   \  \:\     
                \  \:\           \__\/    \  \:\    
                 \__\/                     \__\/    
            """;
            Console.WriteLine(welcomeprint);
            var prompt = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Welcome to ADZ Bank.")
                    .PageSize(6)
                    .MoreChoicesText("[grey](Move up and down)[/]")
                    .AddChoices(new[] {
                    "Withdraw Money", "Deposit Money",
                    "Make a Payment", "Log Out",
                    "End of Day Transaction"
                }));
            return prompt;
        }
    }
    public class GetLocalIP
    {
        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}