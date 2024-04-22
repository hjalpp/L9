using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    internal class Bank
    {
        private static Dictionary<IOperacyjny, List<OperacjaEventArgs>> historiaTransakcji = new Dictionary<IOperacyjny, List<OperacjaEventArgs>>();

        public static void ObslugaOperacji(object sender, OperacjaEventArgs operacja)
        {
            if(sender is IOperacyjny)
            {
                IOperacyjny zrzutowanySender = (IOperacyjny)sender;
                if(!historiaTransakcji.ContainsKey(zrzutowanySender))
                {
                    historiaTransakcji.Add(zrzutowanySender, new List<OperacjaEventArgs>());
                }
                historiaTransakcji[zrzutowanySender].Add(operacja);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IOperacyjny operacyjny in historiaTransakcji.Keys)
            {
                sb.Append(operacyjny.ToString() + "\ntransakcje:\n");
                foreach (OperacjaEventArgs e in historiaTransakcji[operacyjny])
                {
                    sb.Append(e.ToString() + "\n");
                }
            }
            return sb.ToString();
        }
    }
}
