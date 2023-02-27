using System;
using Spectre.Console;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace qrcodeapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Objects
            FileClass file = new FileClass();
            GenerateClass generate = new GenerateClass();

            // Fields
            string prompt = WelcomePrint();
            string QRCodeContent;
            string QRName;
            int QRCodeSize;

            // Codes
            if(prompt == "Generate QR")
            {
                QRCodeContent = AnsiConsole.Ask<string>("[green]Link for QR[/]:");
                QRCodeSize = AnsiConsole.Ask<int>("[green]Size for QR[/]:");
                QRName = AnsiConsole.Ask<string>("[green]Name for QR[/]:");
                generate.GenerateQR(QRCodeContent, QRCodeSize, QRName);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
            }
        }
        static public string WelcomePrint()
        {
            string welcomeprint = """
                                                                                  
             _____ _____    _____ _____ _____ _____ _____ _____ _____ _____ _____ 
            |     | __  |  |   __|   __|   | |   __| __  |  _  |_   _|     | __  |
            |  |  |    -|  |  |  |   __| | | |   __|    -|     | | | |  |  |    -|
            |__  _|__|__|  |_____|_____|_|___|_____|__|__|__|__| |_| |_____|__|__|
               |__|                                                               
            """;
            Console.WriteLine(welcomeprint);
            var prompt = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Welcome to Barcode Generator & Reader.")
                    .PageSize(3)
                    .MoreChoicesText("[grey](Move up and down)[/]")
                    .AddChoices(new[] {
                    "Generate QR", "Exit",
                }));
            return prompt;
        }
        static public void WriteSlowly(string text)
        {
        	string[] words = text.Split(' ');
        	Task t = Task.Run(() =>
        	{
        		foreach (string word in words) {
        			foreach (char letter in word) {
        				Console.Write(letter);
        				Thread.Sleep(100);
        			}

        			Console.Write(" ");
        			Thread.Sleep(250);
        		}
        	});
        	t.Wait();
        }
    }
}