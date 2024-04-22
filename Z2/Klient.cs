using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    internal class Klient : KonfiguracjaHistoriiOperacji, IOperacyjny
    {
        private string imie, nazwisko;
        private decimal saldo;

        private EventHandler<OperacjaEventArgs> operacjaWykonana;

        public Klient(string imie, string nazwisko, decimal saldo) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.saldo = saldo;
        }
        public void Wplata(decimal kwota) 
        {
            this.saldo += kwota;
            operacjaWykonana.Invoke(this, new OperacjaEventArgs(kwota, TypOperacji.Wplata));
        }
        public void Wyplata(decimal kwota)
        {
            if(this.saldo - kwota < 0)
            {
                throw new ArgumentException("brak wystarczających środków na koncie");
            }
            this.saldo -= kwota;
            operacjaWykonana.Invoke(this, new OperacjaEventArgs(kwota, TypOperacji.Wyplata));
        }
        public void Przelew(decimal kwota, IOperacyjny operacyjny)
        {
            this.Wyplata(kwota);
            operacyjny.Wplata(kwota);
            operacjaWykonana.Invoke(this, new OperacjaReceiverEventArgs(kwota, TypOperacji.Przelew, operacyjny));
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override void SetEventHandler(EventHandler<OperacjaEventArgs> handler)
        {
            operacjaWykonana = handler;
        }
        public override string ToString()
        {
            return $"imie: {imie}, nazwisko: {nazwisko}, saldo: {saldo}";
        }
    }
}
