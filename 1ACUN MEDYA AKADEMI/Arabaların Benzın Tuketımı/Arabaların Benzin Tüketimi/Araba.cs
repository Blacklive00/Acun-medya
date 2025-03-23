using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabaların_Benzin_Tüketimi
{
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double BenzinTuketimi { get; set; }

        public Araba(string marka, string model, double benzinTuketimi)
        {
            Marka = marka;
            Model = model;
            BenzinTuketimi = benzinTuketimi;
        }
    }
}
