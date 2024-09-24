using FigureTest.Interfaces;
using System;

namespace FigureTest.Figures
{
    public class Triangle : IFigure
    {
        /// <summary>
        /// Длина первой стороны
        /// </summary>
        public double Side1 { get; set; }

        /// <summary>
        /// Длина второй стороны
        /// </summary>
        public double Side2 { get; set; }

        /// <summary>
        /// Длина третьей стороны
        /// </summary>
        public double Side3 { get; set; }

        /// <summary>
        /// Создание нового треугольника без параметров
        /// </summary>
        public Triangle()
        {
            Side1 = Side2 = Side3 = 0;
        }

        /// <summary>
        /// Создание нового треугольника по трем сторонам
        /// </summary>
        /// <param name="side1">Длина первой стороны</param>
        /// <param name="side2">Длина второй стороны</param>
        /// <param name="side3">Длина третьей стороны</param>
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area
        {
            get
            {
                var perimeter = (Side1 + Side2 + Side3) / 2;
                return Math.Round(Math.Sqrt(perimeter * (perimeter - Side1) * (perimeter - Side2) * (perimeter - Side3)), 1);
            }
        }

        /// <summary>
        /// Проверяет является ли треугольник прямоугольным. Возвращает:
        /// <para>true - если явлется</para>
        /// <para>false - если не явлется</para>
        /// </summary>
        public bool IsRectangular()
        {
            return (Side1 == Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side3, 2)) ||
                    Side2 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2)) ||
                    Side3 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2)));
        }
    }
}
