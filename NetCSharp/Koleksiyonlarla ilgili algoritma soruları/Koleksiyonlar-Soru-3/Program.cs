using System;
using System.Collections;
using System.Collections.Generic;

namespace soru3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            sentence.ToLower();
            List<char> vowelList = new List<char>();
            string vowel = "aeıioüuü";
            foreach (char c in sentence)
            {
                if(vowel.Contains(c))
                {
                    if(!vowelList.Contains(c))
                        vowelList.Add(c);
                }
            }
            Console.WriteLine("***** Vowel List *****");
            foreach(var c in vowelList)
            {
                Console.Write(c + " ");
            }
        }
    }
}