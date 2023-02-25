using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] sumArray = {23, 12, 5, 1, 3, 99, 55};
            
            Console.WriteLine("**** SIRALANMAMIS HALI ****");
            foreach(var sayi in sumArray)
                Console.Write(sayi + " ");
            
            Console.WriteLine("\n**** SIRALANMIS HALI ****");
            Array.Sort(sumArray);
            foreach(var sayi in sumArray)
                Console.Write(sayi + " ");
            Console.WriteLine("\n**** ARRAY CLEAR ****");
            Array.Clear(sumArray, 2, 2);
            foreach(var sayi in sumArray)
                Console.Write(sayi + " ");
            Console.WriteLine("\n**** ARRAY REVERSE ****");
            Array.Reverse(sumArray);
            foreach(var sayi in sumArray)
                Console.Write(sayi + " ");
            Console.WriteLine("\n**** ARRAY IndexOf ****");
            Console.WriteLine(Array.IndexOf(sumArray, 23));
            Console.WriteLine("\n**** ARRAY Resize ****");
            Array.Resize<int>(ref sumArray, 9);
            sumArray[8] = 21;
            foreach(var sayi in sumArray)
                Console.Write(sayi + " ");
        }
    }
}