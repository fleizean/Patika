using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a'dan z'ye karakter yazdırma
            char c = 'a';
            while(c < 'z')
            {
                Console.Write(c);
                c++;
            }
            // Foreach
            string[] arabalar = { "BMW", "FORD", "TOYOTA", "NISSAN" };
            foreach(var a in arabalar)
            {
                Console.WriteLine(a);
            }
        }
    }

}