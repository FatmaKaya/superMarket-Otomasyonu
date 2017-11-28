using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class Urun
    {
        public UrunTanimi Tanım = new UrunTanimi();

        public override string ToString()
        {
            return string.Format("{0}-{1} {2}", Tanım.Ad, Tanım.Fiyatı , "TL");
        }
    }
}
