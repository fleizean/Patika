## Polymorphism (Çok Biçimcilik)

Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor. Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız. Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır. Bunu da virtual ve override anahtar kelimeleri sağlar.

### Virtual metot tanımı:
<code>
public virtual void UyaranlaraTepki(){
    Console.WriteLine("Canlılar uyaranlara tepki verir.");
}
</code>

Alt sınıf içerisinde override metot kullanımı:

<code>
public override void UyaranlaraTepki()
{
    base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır.
    Console.WriteLine("Bitkiler güneşe tepki verir.");
}
</code>
