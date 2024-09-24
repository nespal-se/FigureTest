using FigureTest.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureTest_Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleArea_WithoutValues_0()
        {
            //arrange
            var circle = new Circle();
            //act
            var area = circle.Area;
            //assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void CircleArea_15_AreaOfCircle()
        {
            //arrange
            var radius = 15;
            var circle = new Circle(radius);
            var correctArea = Math.Round(Math.PI * Math.Pow(radius, 2), 1);
            //act
            var area = circle.Area;

            //assert
            Assert.AreEqual(correctArea, area);
        }
    }
}
