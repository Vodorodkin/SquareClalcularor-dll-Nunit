using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareCalcularor.Primitives
{

    public class Triangle : Figure
    {
        private readonly Lazy<bool> _isRightAngled;
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngled => _isRightAngled.Value;

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">Если сторона треугольника имеет отрицательное значение</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            _isRightAngled = new Lazy<bool>(CheckIsRightAngled);
        }

        /// <summary>
        /// Первая сторона
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Третья сторона
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Площадь
        /// </summary>
        protected sealed override double CalculateSquare()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

                var firstSideCoefficient = semiPerimeter - FirstSide;
                var secondSideCoefficient = semiPerimeter - SecondSide;
                var thirdSideCoefficient = semiPerimeter - ThirdSide;

                return Math.Sqrt(semiPerimeter * firstSideCoefficient * secondSideCoefficient * thirdSideCoefficient);          
        }

        /// <summary>
        /// Свойство для проверки треугольника на прямоугольность 
        /// </summary>

        private bool CheckIsRightAngled()
        {
            var maxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            return Math.Pow(maxSide, 2) + Math.Pow(maxSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2);
        }
    }
}
