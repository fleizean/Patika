using System;

namespace reversestring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your word: ");
            var input = Console.ReadLine();
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);
            Console.WriteLine(reversed);
        }
    }
}