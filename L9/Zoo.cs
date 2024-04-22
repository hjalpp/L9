using System;
using System.Collections.Generic;
using System.Text;

namespace L9
{
    internal class Zoo<T> where T : IZwierzecy
    {
        private List<T> zwierzeta = new List<T>();

        public List<T> Zwierzeta
        {
            get
            {
                return zwierzeta;
            }
        }
        public void DodajZwierzeta<U>(U animal) where U : T
        {
            zwierzeta.Add(animal);
        }
        public void UsunZwierzeta<U>(U animal) where U : T
        {
            zwierzeta.Remove(animal);
        }
        public T GetZwierzeAt(int index)
        {
            return zwierzeta[index];
        }
        public void KarmZwierzeta(IEnumerable<T> zwierzeta) 
        {
            foreach(T t in zwierzeta)
            {
                Console.WriteLine(t.WydajDzwiek());
            }
        }
    }
}
