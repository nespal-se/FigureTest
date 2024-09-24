using FigureTest.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureTest_Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleArea_WithoutValues_0()
        {
            //arrange
            var triangle = new Triangle();

            //act
            var area = triangle.Area;

            //assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void TriangleArea_10and20and25_95()
        {
            //arrange
            var triangle = new Triangle(10, 20, 25);

            //act
            var area = triangle.Area;

            //assert
            Assert.AreEqual(95, area);
        }

        [TestMethod]
        public void TriangleIsRectangular_3and4and5_True()
        {
            //arrange
            var triangle = new Triangle(3, 4, 5);

            //act
            var isRect = triangle.IsRectangular();

            //assert
            Assert.IsTrue(isRect);
        }      
    }
}
