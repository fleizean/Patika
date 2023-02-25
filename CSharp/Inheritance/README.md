## Inheritance (Kalıtım)

Bir sınıfın başka bir üst sınıftan miras almasına kalıtım denir. Miras veren sınıf tüm özelliklerini alt sınıfa aktarmış olur.

### Sözdizimi:
<code> Kalıtım Alacak Alt Sınıf : Miras Verecek olan Üst Sınıf </code>

Kalıtım çok soyut bir kavram olması itibariyle anlaşılması zor bir konudur. Bunun için en kolay anlaşılabilecek örnekler üzerinden denenmesinin faydalı olduğunu düşünüyorum. Bu da Canlılar - Hayvanlar - Bitkiler ayrımı ile anlaşılabilir.

Hayvanlar ve Bitkileri canlılar sınıfından türeyen 2 sınıf gibi düşünebilirsiniz. Çünkü hem hayvanların hem bitlilerin ortak bazı özellik ve davranışlar vardır. Bunlar ne olabilir ?

#### Canlılar:

- Beslenme
- Solunum
- Boşaltım

Bu davranışlar hem hayvanlarda hem bitkilerde ortak olduğu için bir sınıf içerisinde tanımlanıp alt sınıflara yani hayvan ve bitkilere kalıtım olarak aktarılabilir. Tıpkı doğada da olduğu gibi.

Peki Hayvanlar sınıfına yakından bakarsak; Kus ve Ordek olarak 2 ayrı sınıf türetebiliriz. Tüm hayvanlarda ortak görülebilecek bitkilerden farklı olarak sürü haline hareket ettiklerini görürüz. Kus ve ördek içinse uçma ve yüzme gibi 2 ayrı davranış var.

#### Hayvanlar:

- Sürü halinde hareket etme

#### Kuş:

- Uçmak

#### Ördek:

- Yüzmek

Buradaki örnekleri arttırmak mümkün. Yazılımda kalıtım üzerinde çalışırken en önemli olan nokta bu gruplamayı doğru yapabilmektir.

Şimdi yukarıdaki modellemeyi koda dökerek sınıfları ve metotlarını yazalım. Devamı kod dosyasında...

