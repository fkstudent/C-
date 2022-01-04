using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Nauczyciel : Uczen
    {
        private string TytulNaukowy;
        private List<Uczen> PodwladniUczniowie;

        public Nauczyciel(string tytulNaukowy, List<Uczen> podwladniUczniowie)
        {
            TytulNaukowy = tytulNaukowy;
            PodwladniUczniowie = podwladniUczniowie;
        }

        public void WhichStudentCanGoHomeAlone()
        {
            Console.WriteLine("Lista:");
            foreach (var VARIABLE in PodwladniUczniowie)
            {
                if (VARIABLE.CanGoAloneToHome() == true)
                {
                    Console.WriteLine(VARIABLE.GetFullName());
                }


            }
        }
    }
}
