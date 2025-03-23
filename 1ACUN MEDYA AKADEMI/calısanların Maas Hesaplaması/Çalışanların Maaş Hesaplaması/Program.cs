using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        List<Calisan> calisanlar = new List<Calisan>
        {
            new Calisan("Ahmet", "Yılmaz", "Genel Müdür", 15000, "Yönetim"),
            new Calisan("Mehmet", "Öztürk", "Müdür", 10000, "Pazarlama"),
            new Calisan("Ayşe", "Kara", "Programcı", 8000, "Bilişim"),
            new Calisan("Fatma", "Demir", "Stajyer", 3000, "İnsan Kaynakları")
        };

        // Çalışan bilgileri
        foreach (var calisan in calisanlar)
        {
            calisan.BilgileriYazdir();
        }

        // Tüm maaşları toplama
        double toplamMaas = 0;
        foreach (var calisan in calisanlar)
        {
            toplamMaas += calisan.Maas;
        }

        // Toplam maaşı ekrana yazdırma
        Console.WriteLine($"\nToplam Maaş: {toplamMaas} TL");
    }
}
