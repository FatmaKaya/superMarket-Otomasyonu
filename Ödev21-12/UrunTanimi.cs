using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class UrunTanimi
    {
        public string Tanım { get; set; }
        public string Ad { get; set; }
        public int UrunKodu { get; set; }
        public decimal Fiyatı { get; set; }
        public int UrunAdet { get; set; }
        public decimal  Tutar { get; set; }
        public int Miktar { get; set; }


        public List<Urun> Urunler { get; set; }
       
        public decimal tutarhesapla()
        {

            this.Tutar = this.Miktar * this.Fiyatı;
           
            return Tutar;
        }

    }
}
