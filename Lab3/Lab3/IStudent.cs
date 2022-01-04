using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
        public interface IStudent : IOsoba
        {
            void SetUczelania(String uczelnia);
            void SetKierunek(String Kierunek);
            void SetRok(String Rok);
            void SetSemestr(String Semestr);
        }
    
}

