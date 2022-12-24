using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string degisken = "Dersiniz CSharp, Hosgeldaniel";
            string degisken2 = "CSharp";
             //Length;
            Console.WriteLinedegisken.Length();
            //Tolipper ToLower
            Console.Writeline(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            //Conpare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));
             //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));
            //Index0f
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Enes"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Consele.WriteLine(degisken.Insert(0, "Merhaba "));

            //PadLeft, PadRight;
            Console.Writeline(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}