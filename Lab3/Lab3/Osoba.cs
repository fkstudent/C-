using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Osoba : IOsoba
     {
        private string imie;
        private string nazwisko;

        public string ZwrocPelnaNazwe()
        {
            return imie + " " + nazwisko;
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public Osoba()
        {
        }

        public void SetImie(string imie)
        {
            this.imie = imie;
        }

        public void SetNazwisko(string nazwiko)
        {
            this.nazwisko = nazwiko;
        }

        public string GetNazwiko()
        {
            return nazwisko;
        }
    }
}
