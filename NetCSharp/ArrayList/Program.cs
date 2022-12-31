using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Jonathan");
            list.Add(2);
            list.Add(true);
            list.Add('C');

            Console.WriteLine(list[1]);

            foreach(var item in list)
                Console.WriteLine(item);

            string[] colors = {"Red", "Yellow", "Blue", "Purple"};
            List<int> sumArray = new List<int>(){1,5,9,2,4,33,99};
            list.AddRange(colors);
            list.AddRange(sumArray);

            foreach(var item in list)
                Console.WriteLine(list);

            list.Sort();
            foreach(var item in list)
                Console.WriteLine(item);
            
            Console.WriteLine(list.BinarySearch(9));

            list.Reverse();
            foreach(var item in list)
                Console.WriteLine(list);

            list.Clear();
            foreach(var item in list)
                Console.WriteLine(list);
        }
    }
}