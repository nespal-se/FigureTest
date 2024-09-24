using FigureTest.Interfaces;
using System;

namespace FigureTest.Figures
{
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area => Math.Round(Math.PI * Math.Pow(Radius, 2), 1);

        /// <summary>
        /// Создание новой окружности без параметров
        /// </summary>
        public Circle()
        {
            Radius = 0;
        }

        /// <summary>
        /// Создание новой окружности
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
