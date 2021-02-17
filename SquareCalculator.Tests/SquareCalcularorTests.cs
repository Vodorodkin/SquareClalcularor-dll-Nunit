using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SquareCalcularor.Primitives;

namespace SquareCalculator.Tests
{
    [TestFixture]
    public class SquareCalcularorTests
    {
        /// <summary>
        /// Тестируем отрицательный радиус круга
        /// </summary>
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        /// <summary>
        /// Тестируем отрицательные стороны треугольника
        /// </summary>
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-5, 5, 5));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(5, -5, 5));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(5, 5, -5));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-5, -5, -5));
        }

        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [Test]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new Circle(5);

            //Act
            var circleSquare = circle.Square;

            //Assert
            Assert.AreEqual(78.53981633974483, circleSquare);
        }

        /// <summary>
        /// Тестируем вычисление площади тиугольника
        /// </summary>
        [Test]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var triangleSquare = triangle.Square;

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [Test]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.AreEqual(true, isTriangleRightAngled);
        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [Test]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(6, 2, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }
    }
}
