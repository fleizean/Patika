using System;
					
public class Program
{
    	public static void Main()
	{
		// Söz Dizimi
		// class SinifAdi
		// {
		//		[Erişim Belirleyici] [Veri Tipi] OzellikAdi;
		//		[Erişim Belirleyici] [Geri Donus Tipi] MetotAdi([Parametre Listesi)]
		//		{
		//			// Metot Komutları
		//		}
		// }
		
		// Erişim Belirleyiciler
		// * Public
		// * Private
		// * Internal
		// * Protected
		Calisan c1 = new Calisan("Ayşe", "Kara", 23465768, "İK");
		c1.CalisanBilgileri();
		Console.WriteLine("**********");
		Calisan c2 = new Calisan();
		c2.Ad = "Deniz";
		c2.Soyad = "Üstün";
		c2.No = 23465765;
		c2.Departman = "DK";
		c2.CalisanBilgileri();
		Console.WriteLine("***********");
		Calisan c3 = new Calisan("Zikriye", "Ürkmez");
		c3.CalisanBilgileri();	
	}
	class Calisan
	{
		private string _Ad;
		private string _Soyad;
		private int _No;
		private string _Departman;
		
		// get set area
		public string Ad 
  		{
    		get { return _Ad; } 
    		set { _Ad = value; }
  		}
		public string Soyad
  		{
    		get { return _Soyad; }
    		set { _Soyad = value; }
  		}
		public int No
  		{
    		get { return _No; }
    		set { _No = value; }
  		}
		public string Departman
  		{
    		get { return _Departman; }
    		set { _Departman = value; }
  		}

		// default constructor with a parameters
		public Calisan(string ad, string soyad, int no, string departman)
		{
			Ad = ad;
			Soyad = soyad;
			No = no;
			Departman = departman;
		}
		public Calisan(string ad, string soyad)
		{
			Ad = ad;
			Soyad = soyad;
		}
		// default constructor
		public Calisan(){}
		// public methods
		public void CalisanBilgileri()
		{
			Console.WriteLine("Çalışanın Adı: {0}", Ad);
			Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
			Console.WriteLine("Çalışanın Numarası: {0}", No);
			Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
		}
	}
}