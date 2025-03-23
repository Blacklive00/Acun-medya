using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Araba yaşını giriniz:");
        int arabaYasi = int.Parse(Console.ReadLine());
        string durumMesaji = ArabaDurumu(arabaYasi);
        Console.WriteLine(durumMesaji);
    }

    static string ArabaDurumu(int arabaYasi)
    {
        switch (arabaYasi)
        {
            case int n when (n >= 0 && n <= 10):
                return "Arabanız yeni";
            case int n when (n > 10 && n <= 20):
                return "Servise götürmeniz gerekebilir";
            case int n when (n > 20 && n <= 30):
                return "Arabanız hurdaya çıkabilir";
            default:
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }
    }
}
