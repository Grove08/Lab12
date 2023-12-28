using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = Convert.ToDouble(Console.ReadLine());



            double length = Circle.GetLength(radius);
            double area = Circle.GetArea(radius);

            Console.WriteLine($"Длина окружности: {length}");
            Console.WriteLine($"Площадь круга: {area}");

            Console.WriteLine("Введите координаты точки (x, y) для проверки принадлежности кругу:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            bool isInside = Circle.IsPointInsideCircle(x, y, 0, 0, radius);

            Console.WriteLine($"Точка ({x}, {y}) принадлежит кругу: {isInside}");
            Console.ReadKey();
        }
    }
}
