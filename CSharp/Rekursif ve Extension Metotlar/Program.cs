using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = 3;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);
            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            string ifade = "Test Ediyoz";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(ifade.CheckSpace());
            if(sonuc)
                Console.WriteLine(ifade.RemoveSpace());
            Console.WriteLine(ifade.makeUpper());
            Console.WriteLine(ifade.makeLower());

            int[] arr = {9, 3, 6, 2, 1, 5, 0};
            arr.SortandReturn();
            arr.EkranaYazdir();

            int sum = 5;
            Console.WriteLine(sum.IsEven());

            Console.WriteLine(ifade.GetFirst());
        }
    }
    public class Islemler
    {
        public int Expo(int s1, int us)
        {
            if(us < 2)
                return(s1);
            return(Expo(s1, us - 1) * s1);
        }
    }

    public static class Extension
    {
        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveSpace(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }
        public static string makeUpper(this string param)
        {
            return param.ToUpper();
        }
        public static string makeLower(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortandReturn(this int[] arr)
        {
            return Array.Sort(arr);
        }
        public static void EkranaYazdir(this int[] arr)
        {
            foreach(var s in arr)
                Console.WriteLine(s); 
        }
        public static bool IsEven(this int sum)
        {
            return(sum % 2 == 0);
        }
        public static string GetFirst(this string text)
        {
            return(text.Substring(0, 1));
        }
    }
}
