namespace FiguresLibraryMindBox
{
    public class Circle : Figure
    {
        private double radius;
        private double Area;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        /// <summary>
        /// Выводит площадь круга
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(radius, 2);
            return Area;
        }




    }
}
