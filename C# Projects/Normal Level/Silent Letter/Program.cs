using System;

namespace silentletter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the word: ");
            string input = Console.ReadLine();

            string[] parse = input.Split(' ');
            foreach (string word in parse)
            {
                bool hasConsecutiveConsonants = CheckConsonants(word);
                Console.WriteLine($"{word}: {hasConsecutiveConsonants}");
            }
        }
        static bool CheckConsonants(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if ("bcdfghjklmnpqrstvwxyz".Contains(word[i].ToString()) && "bcdfghjklmnpqrstvwxyz".Contains(word[i + 1].ToString()))
                {
                    return true;
                }
            }

            return false;
        }
    }
}