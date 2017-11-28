using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public  class KasaGorevlisi : Kisi
    {
        public long KimlikNo { get; set; }
        public string SigortaNo { get; set; }
        public Terminal Terminal { get; set; }

        public KasaGorevlisi()
        {
            Terminal = new Terminal();
        }
        public override void KisiBilgisiDoldur(string Ad, string Soyad, string SigortaNo)
        {
            base.KisiBilgisiDoldur(Ad, Soyad, SigortaNo);
            this.SigortaNo = SigortaNo.ToUpper();
            
        }
      
        public KasaGorevlisi(string ad, string soyad, string sigortaNo, long telefon)
        {
            this.Ad = ad.ToUpper();
            this.Soyad = soyad.ToUpper();
            this.SigortaNo = sigortaNo.ToUpper();
            this.Telefon = telefon;
        }
    }
}
