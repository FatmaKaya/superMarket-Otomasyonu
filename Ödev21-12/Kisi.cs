using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        protected long Telefon { get; set; }

        public virtual void KisiBilgisiDoldur(string Ad, string Soyad, string SigortaNo)
        {
            this.Ad = Ad.ToUpper();
            this.Soyad = Soyad.ToUpper();
        }
    }
}
