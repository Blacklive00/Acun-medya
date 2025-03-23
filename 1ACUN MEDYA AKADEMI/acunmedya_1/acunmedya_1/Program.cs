using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen yaşınızı giriniz: ");
        int yas = int.Parse(Console.ReadLine());
        Console.WriteLine(YasKategorisiBelirleme(yas));
    }

    static string YasKategorisiBelirleme(int yas)
    {
        if (yas < 0 || yas > 99)
        {
            return "Ya hiç doğmadınız ya da ölmek üzeresin.";
        }
        else if (yas < 18)
        {
            return "Küçüksünüz";
        }
        else if (yas < 35)
        {
            return "Gençsiniz";
        }
        else if (yas < 55)
        {
            return "Yetişkinsiniz";
        }
        else if (yas < 75)
        {
            return "Yaşlısınız";
        }
        else
        {
            return "Çok yaşlısınız";
        }
    }
}
