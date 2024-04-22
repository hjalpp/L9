using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    internal abstract class KonfiguracjaHistoriiOperacji
    {
        public KonfiguracjaHistoriiOperacji()
        {
            SetEventHandler(Bank.ObslugaOperacji);
        }
        public abstract void SetEventHandler(EventHandler<OperacjaEventArgs> handler);


    }
}
