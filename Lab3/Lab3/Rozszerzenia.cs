using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class Rozszerzenia
    {
        public static void WypiszOsoby(this List<Osoba> lista)
        {
            foreach (var VARIABLE in lista)
            {
                Console.WriteLine(VARIABLE.ZwrocPelnaNazwe());
            }
        }
        public static void PosortujOsobyPoNazwisku(this List<Osoba> lista)
        {
            lista.Sort((osoba1, osoba2) => osoba1.GetNazwsiko().CompareTo(osoba2.GetNazwsiko()));
        }
    }
}
