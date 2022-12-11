using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string renkler = new string[5];
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            Console.Write("Eleman sayısı giriniz : ");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for(int i = 0; i < arrLength; i++)
            {
                Console.Write("{0}. sayıyı giriniz : ",i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach(var sayi in arr)
            {
                toplam += sayi;
            }
            Console.WriteLine("Dizinin ortalaması ", toplam / arrLength);
        }
    }
}