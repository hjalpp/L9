using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    internal class OperacjaReceiverEventArgs : OperacjaEventArgs
    {
        private IOperacyjny receiver;

        public OperacjaReceiverEventArgs(decimal kwota, TypOperacji typOperacji, IOperacyjny receiver) : base(kwota, typOperacji)
        {
            this.receiver = receiver;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, receiver: {receiver}";
        }
    }
}
