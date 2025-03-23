using Arabaların_Benzin_Tüketimi;

class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", "Corolla", 7.5),
            new Araba("Honda", "Civic", 6.8),
            new Araba("Ford", "Focus", 7.2)
        };
        double toplamTuketim = 0;

        foreach (Araba araba in arabalar)
        {
            toplamTuketim += araba.BenzinTuketimi;
        }

        Console.WriteLine("Toplam Benzin Tüketimi: " + toplamTuketim + " litre/100km");
    }
}
