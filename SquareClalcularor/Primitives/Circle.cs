using System;
using System.Collections.Generic;
using System.Text;

namespace SquareCalcularor.Primitives
{
    public class Circle : Figure
    { 
        /// <summary>
        /// Конструктор круга
        /// </summary>
        /// <param name="raidus">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус круга меньше нуля</exception>
        public Circle(double raidus)
        {
            if (raidus < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            this.Radius = raidus;
        }

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Площадь
        /// </summary>
        protected sealed override double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
            
        }


    }
}
