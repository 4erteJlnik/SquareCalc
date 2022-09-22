using FiguresLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleAreaTestMethod()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedArea = 6;

            //Act
            Triangle triangle = new Triangle(a, b, c);
            double actualArea = triangle.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, actualArea, "Неправильный метод подсчета площади треугольника");
        }

        [TestMethod]
        public void TrianglePerimeterTestMethod()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedPerimeter = 12;

            //Act
            Triangle triangle = new Triangle(a, b, c);
            double actualPerimeter = triangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, "Неправильный метод подсчета периметра треугольника");
        }
    }
}
