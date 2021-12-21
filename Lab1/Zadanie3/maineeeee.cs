using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    internal class maineeeee
    {
        static void Main(string[] args)
        {
            Data d1 = new Data(20,12,2000);
            Console.WriteLine("Nasz data: ");
            d1.WypiszDate();

            d1.dodajTydzien();
            d1.WypiszDate();
            d1.dodajTydzien();
            d1.WypiszDate();
            d1.dodajTydzien();
            d1.WypiszDate();


            d1.odejmijTydzien();
            d1.WypiszDate();
            d1.odejmijTydzien();
            d1.WypiszDate();
            d1.odejmijTydzien();
            d1.WypiszDate();

        }
    }
}
