using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    internal class OperacjaEventArgs : EventArgs
    {
        private decimal kwota;
        private TypOperacji typOperacji;

        public OperacjaEventArgs(decimal kwota, TypOperacji typOperacji)
        {
            this.kwota = kwota;
            this.typOperacji = typOperacji;
        }

        public override string ToString()
        {
            return $"kwota: {kwota}, typ operacji: {typOperacji}";
        }
    }
}
