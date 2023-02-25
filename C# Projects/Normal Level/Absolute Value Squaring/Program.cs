using System;

namespace absolutevalues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int smallerSum = 0;
            int largerSum = 0;

            Console.WriteLine("Example(56 45 68 77)");
            Console.Write("Write your values: ");
            string input = Console.ReadLine();

            string[] parse = input.Split(' ');
            for(int i = 1; i <= parse.Length; i++)
            {
                string str = parse[i - 1].Trim();
                int val = Convert.ToInt32(str);
                if (val < 67)
                {
                    smallerSum += (67 - val);
                }
                else
                {
                    largerSum += (val - 67) * (val - 67);
                }
            }
            Console.WriteLine(smallerSum + " " + largerSum);
        }
    }
}
