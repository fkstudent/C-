using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Uczen : Osoba
    {
        private string szkoła;
        private bool MozeSamWracacDoDomu;

        public Uczen(string imie, string nazwisko, string pesel, string szkoła, bool mozeSamWracacDoDomu) : base(imie, nazwisko, pesel)
        {
            this.szkoła = szkoła;
            MozeSamWracacDoDomu = mozeSamWracacDoDomu;
        }

        public Uczen()
        {
        }

        public override void GetEducationInfo()
        {
            Console.WriteLine(szkoła);
        }

        public override bool CanGoAloneToHome()
        {
            return MozeSamWracacDoDomu;
        }

        public string GetSchool()
        {
            return this.szkoła;
        }

        public void SetSchool(string szkola)
        {
            this.szkoła = szkola;
        }

        public void SetCanGoHomeAlone(bool pozwolenie)
        {
            if (pozwolenie == true)
            {
                Console.WriteLine("Mozę");
            }
            else
            {
                Console.WriteLine("Nie może");
            }
            this.MozeSamWracacDoDomu = pozwolenie;
        }
    }
}
