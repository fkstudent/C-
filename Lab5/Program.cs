using System;

public class Program
{
	public Program
	{
        static void Main(string[] args)
        {
            /*Zadanie5*/
            Person copyPerson(Person original)
            {
                var clone = new Person();
                clone.name = original.name;
                clone.surname = original.surname;
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
}
