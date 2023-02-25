using System;

namespace characterreplacement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the word: ");
            string input = Console.ReadLine();

            string[] parse = input.Split(' ');
            for(int i = 1; i <= parse.Length; i++)
            {
                if (parse[i - 1].Length <= 1) {
                    Console.WriteLine("The word cannot consist of a single character!");
                }
                else {
                    char firstChar = parse[i - 1][0];
                    char lastChar = parse[i - 1][parse[i - 1].Length - 1];

                    string newWord = lastChar + parse[i - 1].Substring(1, parse[i - 1].Length - 2) + firstChar;

                    Console.WriteLine("New Word: " + newWord);
                }
            }
        }
    }
}