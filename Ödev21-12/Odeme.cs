using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public abstract class Odeme
    {
        public decimal OdemeMiktari { get; set; }

        public abstract void Ode(decimal tutar);
    }
}
