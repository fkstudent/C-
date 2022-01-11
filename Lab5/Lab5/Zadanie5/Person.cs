using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Zadanie5
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            this.age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int age { get; set; }
    }
}
