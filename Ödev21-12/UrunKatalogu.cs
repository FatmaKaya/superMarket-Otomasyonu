 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class UrunKatalogu
    {
        public Dukkan Dukkanimiz { get; set; }
        public UrunTanimi UrunTanimi { get; set; }

        public UrunKatalogu()
        {
            this.Dukkanimiz = new Dukkan();
        }
    }
}
