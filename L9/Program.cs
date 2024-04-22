using System;

namespace L9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zoo = new Zoo<IZwierzecy>();

            zoo.DodajZwierzeta(new Pies());

            zoo.DodajZwierzeta(new Kot());

            zoo.DodajZwierzeta(new Ryba());

            zoo.KarmZwierzeta(zoo.Zwierzeta); // Hau hau!, Miau miau!, Bul bul!
        }
    }
}
