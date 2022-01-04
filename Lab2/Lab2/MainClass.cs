using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Zadanie1();
        }

        public static void Zadanie1()
        {
            List<Shape> list = new List<Shape>();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();
            Circle circle = new Circle();
            list.Add(rectangle);
            list.Add(triangle);
            list.Add(circle);
            foreach (var shape in list)
            {
                shape.Draw();
            }
        }

    }
}
