using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    internal interface IOperacyjny : ICloneable
    {
        public void Przelew(decimal kwota, IOperacyjny operacyjny);
        public void Wplata(decimal kwota);
        public void Wyplata(decimal kwota);

    }
}
