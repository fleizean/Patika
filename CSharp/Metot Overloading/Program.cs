using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Basarili");
                Console.WriteLine(outSayi);
            }
            else
                Console.WriteLine("Basarisiz");
            Metotlar istance = new Metotlar();
            istance.Topla(4,5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            int ifade = 999;
            istance.ekranaYazdir(Conver.ToString(ifade));
            istance.ekranaYazdir(ifade);
            istance.ekranaYazdir("Enes", "Test");

        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, int toplam)
        {
            toplam = a+b;
        }
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri1, int veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
