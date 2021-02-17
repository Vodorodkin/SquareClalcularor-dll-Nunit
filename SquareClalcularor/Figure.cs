using System;

namespace SquareCalcularor
{
    /// <summary>
    /// Базовый класс для фигур
    /// </summary>
    public abstract class Figure
    {
        private readonly Lazy<double> _square;
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Square => _square.Value;
        protected Figure()
        {
            _square = new Lazy<double>(CalculateSquare);
        }
        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        protected abstract double CalculateSquare();
    }
}
