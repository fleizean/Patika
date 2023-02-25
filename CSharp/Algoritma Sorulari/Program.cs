//Soru 1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

#region soru1
/*
    int n;
    Console.Write("Pozitif bir sayi giriniz: ");
    n = Convert.ToInt32(Console.ReadLine());
    int[] arrList = new int[n];
    for(int i = 0; i < n; i++)
    {
        Console.Write("{0}. Sayi: ",i + 1);
        arrList[i] = Convert.ToInt32(Console.ReadLine());
    }
    foreach(var sum in arrList)
    {
        if(sum % 2 == 0)
            Console.WriteLine(sum);
    }
*/
#endregion

//Soru 2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

#region soru2
/*
    Console.Write("Pozitif n sayisini giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Pozitif m sayisini giriniz: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] arrList = new int[n];
    for(int i = 0; i < n; i++)
    {
        Console.Write("{0}. Sayi: ",i + 1);
        arrList[i] = Convert.ToInt32(Console.ReadLine());
    }
    foreach(var sum in arrList)
    {
        if(sum % m == 0 || sum == m)
            Console.WriteLine(sum);
    }
*/
#endregion

#region soru3
/*
    Console.Write("Pozitif n sayisini giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] wordarray = new string[n];
    for(int i = 0; i < n; i++)
    {
        Console.Write("{0}. Kelime: ",i + 1);
        wordarray[i] = Console.ReadLine();
    }
    Array.Reverse(wordarray);
    foreach (string w in wordarray)
        Console.WriteLine(w);
*/
#endregion

#region soru4
/*
    Console.Write("Bir cumle giriniz: ");
    string text = Console.ReadLine();
    int cumle = 0;
    foreach(char c in text)
    {
        if(c == ' ')
            cumle++;
    }
    Console.WriteLine("Toplam cümle sayisi : {0} ve Toplam karakter sayisi : {1}",cumle + 1, text.Length);
*/
#endregion