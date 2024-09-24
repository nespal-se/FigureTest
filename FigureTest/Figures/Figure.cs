using FigureTest.Interfaces;


namespace FigureTest.Figures
{
    public class Figure : IFigure
    {
        private IFigure figure;

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area => figure.Area;

        /// <summary>
        /// Создание новой фигуры
        /// </summary>
        /// <param name="figure">Фигура</param>
        public Figure(IFigure figure) => this.figure = figure;
    }
}
