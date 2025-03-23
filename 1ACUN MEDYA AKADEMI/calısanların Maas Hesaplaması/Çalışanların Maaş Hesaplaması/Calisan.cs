using System;

public class Calisan
{
   
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Meslek { get; set; }
    public double Maas { get; set; }
    public string Departman { get; set; }

   
    public Calisan(string ad, string soyad, string meslek, double maas, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Meslek = meslek;
        Maas = maas;
        Departman = departman;
    }

    // Çalışanın bilgilerini yazdıran metot
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad} {Soyad}, Meslek: {Meslek}, Maaş: {Maas} TL, Departman: {Departman}");
    }
}
