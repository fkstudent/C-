using Lab5.Zadanie5;
using System;

internal class Program
{
        static void Main(string[] args)
        {
            /*Zadanie5*/
            Person copyPerson(Person original)
            {
                var clone = new Person();
                clone.Name = original.Name;
                clone.Surname = original.Surname;
                clone.age = original.age;
                return clone;
            }

            Person p1 = new Person("Marzena", "Essa", 11);
            copyPerson(p1);
            Console.WriteLine(p1);
            p1.ToString();
            Console.WriteLine(copyPerson(p1));
        }
	}
