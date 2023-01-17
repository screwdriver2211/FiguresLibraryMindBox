using FiguresLibraryMindBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibraryTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleTestMethod()
        {
            double aSide = 3;
            double bSide = 4;
            double cSide = 5;
            double correctValue = 6;

            Triangle triangle = new Triangle(aSide, bSide, cSide);
            double resultValue = triangle.GetArea();

            Assert.AreEqual(correctValue, resultValue, "Test failed");
        }
    }
}
