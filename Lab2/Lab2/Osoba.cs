using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Osoba
    {
        private string imie;
        private string nazwisko;
        private char[] pesel;

        public Osoba(string imie, string nazwisko, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel.ToCharArray();
        }

        public Osoba()
        {
        }

        public void SetFirstName(string imie)
        {
            this.imie = imie;
        }

        public void SetLasttName(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

        public void SetPesel(string pesel)
        {
            this.pesel = pesel.ToCharArray();
        }

        public int GetAge(DateTime date)
        {
            int dzien = (int)pesel[4] * 10 + (int)pesel[5];
            int miesiac = (int)pesel[2] * 10 + (int)pesel[3];
            int rok;
            if (miesiac < 13)
            {
                rok = 1900 + (int)pesel[0] * 10 + (int)pesel[1];
            }
            else
            {
                rok = 2000 + (int)pesel[0] * 10 + (int)pesel[1];
            }

            int wiek = date.Year - rok;
            if (date.Month > miesiac)
            {
                wiek--;
            }
            else
            {
                if (date.Month == miesiac)
                {
                    if (date.Day > dzien)
                    {
                        wiek--;
                    }
                }
            }

            return wiek;
        }

        public string GetGender()
        {
            if (int.Parse(pesel[9].ToString()) % 2 == 1)
            {
                return "M";
            }
            else
            {
                return "K";
            }
        }

        public virtual void GetEducationInfo()
        {
        }

        public string GetFullName()
        {
            return this.imie + " " + this.nazwisko;
        }

        public virtual bool CanGoAloneToHome()
        {
            return true;
        }
    }
}
