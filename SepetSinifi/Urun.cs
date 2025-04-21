using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetımı
{
    class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public int Adet { get; set; }

        public Urun(int id, string ad, double fiyat , int adet=1)
        {
            Id = id;
            Ad = ad;
            Fiyat = fiyat;
            Adet=adet;
        }

        public override string ToString()
        {
            return $"{Ad} ({Adet} adet) — {Fiyat * Adet:0.00} TL";
        }
    }
}
