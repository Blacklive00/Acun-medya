using System;

class Program
{
    static void Main(string[] args)
    {
        double[] sayilar = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Lütfen {0}. sayıyı girin: ", i + 1);
            sayilar[i] = Convert.ToDouble(Console.ReadLine());
        }
        double toplam = 0;

        for (int i = 0; i < 5; i++)
        {
            toplam += sayilar[i];
        }
        double ortalama = toplam / 5;

        Console.WriteLine("Sayıların Ortalaması: " + ortalama);
    }
}
