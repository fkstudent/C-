using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Student : IStudent
    {
        private String Imie;
        private String Nazwisko;
        private String Uczelnia;
        private String Kierunek;
        private String Rok;
        private String Semestr;

        public Student(string imie, string nazwisko, string uczelnia, string kierunek, string rok, string semestr)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Uczelnia = uczelnia;
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }

        public Student()
        {
        }

        public void SetImie(string imie)
        {
            this.Imie = imie;
        }

        public void SetNazwisko(string nazwiko)
        {
            this.Nazwisko = nazwiko;
        }

        public string GetNazwiko()
        {
            return Nazwisko;
        }

        public string ZwrocPelnaNazwe()
        {
            return Imie + " " + Nazwisko;
        }

        public void SetUczelania(string uczelnia)
        {
            this.Uczelnia = uczelnia;
        }

        public void SetKierunek(string kierunek)
        {
            this.Kierunek = kierunek;
        }

        public void SetRok(string rok)
        {
            this.Rok = rok;
        }

        public void SetSemestr(string semestr)
        {
            this.Semestr = semestr;
        }

        public String WypiszPelnaNazweIUczelnie()
        {
            return ZwrocPelnaNazwe() +" "+ this.Uczelnia + " " + this.Kierunek + " " + this.Rok + " " + this.Semestr;
        }
    }
}
