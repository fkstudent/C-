using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class MainLab3
    {
        static void Main(string[] args)
        {
            List<Osoba> list = new List<Osoba>();
            Osoba o1 = new Osoba("Adam", "Kowalski");
            Osoba o2 = new Osoba("Adrian", "Nowak");
            Osoba o3 = new Osoba("Marian", "Takowy");
            Osoba o4 = new Osoba("Izabela", "Izowska");
            list.Add(o1);
            list.Add(o2);
            list.Add(o3);
            list.Add(o4);

            Console.WriteLine("Lista osob: ");
            list.WypiszOsoby();
            Console.WriteLine("lista posortowana: ");
            list.PosortujOsobyPoNazwisku();
            list.WypiszOsoby();

            Console.WriteLine("Studenciak");
            Student student = new Student();
            student.SetImie("Marek");
            student.SetNazwisko("Niewiem");
            student.SetUczelania("URZ");
            student.SetRok("2001");
            student.SetKierunek("Biolgia");
            student.SetSemestr("6");
            Console.WriteLine(student.WypiszPelnaNazweIUczelnie());


            List<StudentUR> lista2 = new List<StudentUR>();
            StudentUR studur1 = new StudentUR("Mirek", "Mireczek", "Uniwersytet Rzeszowski", "Informatyka","2002", "3");
            StudentUR studur2 = new StudentUR("Yśsa", "Ącki", "Uniwersytet Rzeszowski", "Informatyka","2000", "2");
            lista2.Add(studur1);
            lista2.Add(studur2);
        }
    }
}
