using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine("y new result : {0}", y);
            y += 2;
            Console.WriteLine("y new result : {0}", y);
            y /= 1;
            Console.WriteLine("y new result : {0}", y);
            x *= 2;
            Console.WriteLine("x new result : {0}", x);

            // Mantıksal operatörler

            bool isOK = true;
            bool isCompleted = false;

            if(isOK && isCompleted)
                Console.WriteLine("Perfect");
            if(isOK || isCompleted)
                Console.WriteLine("Great");
            if(isOK && !isCompleted)
                Console.WriteLine("Fine");

            // İlişkisel operatörler

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            // Aritmetik Operatorler
            int d = 32;
            int e = 3;
            int result2 = d / e;
            Console.WriteLine(result2);

            result2 = d % 2;
            Console.WriteLine(result2);
        }
    }
}