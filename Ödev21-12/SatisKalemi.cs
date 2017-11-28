using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class SatisKalemi
    {
        public List<Urun> AlinanUrunler { get; set; }

        public void UrunEkle(Urun u)
        {
            AlinanUrunler.Add(u);

        }

        
        public string UrunListele()
        {
            string mesaj = "";
            foreach (Urun u in AlinanUrunler)
            {
                {
                    mesaj += "\n\n Ürün Kodu: " + u.Tanım.UrunKodu.ToString() +
                             "\nÜrün Adı: " + u.Tanım.Ad +
                             "\nÜrün Fiyatı: " + u.Tanım.Fiyatı.ToString() +" TL";
                }

            }
            return mesaj;
        }


        public SatisKalemi()
        {
            AlinanUrunler = new List<Urun>();
        }


    }
}
