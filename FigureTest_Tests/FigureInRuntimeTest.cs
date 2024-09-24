using FigureTest.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureTest_Tests
{
    [TestClass]
    public class FigureInRuntimeTest
    {
        [TestMethod]
        public void AreaOfFigure_TriangleWithoutValues_0()
        {
            //arrange
            var figure = new Figure(new Triangle());

            //act
            var area = figure.Area;

            //assert
            Assert.AreEqual(0, area);
        }
    }
}
