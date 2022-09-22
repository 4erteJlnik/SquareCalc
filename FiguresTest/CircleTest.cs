using FiguresLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleAreaTestMethod()
        {
            //Arrange
            double radius = 3;
            double expectedArea = 28.274333882308138;

            //Act
            Circle circle = new Circle(radius);
            double actualArea = circle.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, actualArea, "Неправильный метод подсчета площади окружности");
        }

        [TestMethod]
        public void CirclePerimeterTestMethod()
        {
            //Arrange
            double radius = 3;
            double expectedPerimetr = 18.849555921538759430775860299677;

            //Act
            Circle circle = new Circle(radius);
            double actualPerimetr = circle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedPerimetr, actualPerimetr, "Неправильный метод подсчета периметра окружности");
        }
    }
}
