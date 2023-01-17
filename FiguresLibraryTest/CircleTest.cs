using FiguresLibraryMindBox;
namespace FiguresLibraryTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleTestMethod()
        {
            double radius = 10;
            double correctValue = 314.1592653589793;

            Circle circle = new Circle(radius);
            double resultValue = circle.GetArea();

            Assert.AreEqual(correctValue, resultValue, "Test failed");
        }
    }
}