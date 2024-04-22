using System;

namespace Z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Klient klient1 = new Klient("Jan", "Kowalski", 1000);

            Klient klient2 = new Klient("Janusz", "Tracz", 10000000);

            klient1.Wyplata(120);

            klient1.Wplata(10000);

            klient1.Przelew(1000, klient2);

            Console.WriteLine(bank);
        }
    }
}
