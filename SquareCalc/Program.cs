using System;
using FiguresLibrary;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();

            Console.WriteLine("Введите 3 стороны треугольника:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Figure triangle = new Triangle(a, b, c);
            Console.WriteLine("Треугольник: ");
            triangle.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Figure Circle = new Circle(r);
            Circle.DisplayInfo();
        }
    }
}
