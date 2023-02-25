using System;

namespace algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your parameters(Text, Num): ");
            string input = Console.ReadLine();
            if(input == null)
                Console.WriteLine("Wrong parameters");
            else
            {
                string[] parse = input.Split(',');
                string str = parse[0].Trim();
                int indexnum = int.Parse(parse[1].Trim());

                string word = str.Remove(indexnum, 1);
                Console.WriteLine("Result: {0}", word);
                Console.WriteLine("Removed Character: {0}",str[indexnum]);
            }
        }
    }
}
