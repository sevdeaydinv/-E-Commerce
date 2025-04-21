using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetımı
{
    class Sepet
    {
        public List<Urun> urunler = new List<Urun>();

        public void UrunEkle(Urun urun)
        {
            urunler.Add(urun);
        }

        public double ToplamTutar()
        {
            double toplam = 0;
            foreach (var u in urunler)
                toplam += u.Fiyat * u.Adet; // Adet çarpımı eklendi
            return toplam;
        }

        public string SepetiListele()
        {
            string liste = "";
            foreach (var urun in urunler)
                liste += urun.ToString() + "\n";

            liste += $"\nToplam: {ToplamTutar():0.00} TL";
            return liste;
        }

        public void SepetiTemizle()
        {
            urunler.Clear();
        }

        internal object ToplamFiyat()
        {
            throw new NotImplementedException();
        }
    }
}
