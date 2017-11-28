using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class NakitOdeme : Odeme
    {
        private const decimal INDIRIMORANI = 0.05M;
        public decimal Indirim { get; private set; }
        public override void Ode(decimal tutar)
        {
            Indirim = tutar * INDIRIMORANI;
            OdemeMiktari = tutar - Indirim;
            
            
        }
    }
}
