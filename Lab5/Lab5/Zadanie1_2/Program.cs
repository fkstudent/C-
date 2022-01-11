using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Zadanie1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int napis(string n)
            {
                return n.Length;
            }

            try
            {
                Console.WriteLine(napis("esaaaa"));
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.StackTrace);
                throw new Exception("cant be null", e);



                Random Rand = new Random();
                switch (Rand.Next(1, 4))
                {
                    case 1:
                        {
                            try
                            {

                                throw new Exception();

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Wyjatek 1");
                            }
                            break;
                        }

                    case 2:
                        {
                            try
                            {
                                throw new Exception();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Wyjatek 2");
                            }


                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                throw new Exception();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Wyjatek 3");
                            }
                            break;
                        }

                }
            }
        }
    }
}
              
