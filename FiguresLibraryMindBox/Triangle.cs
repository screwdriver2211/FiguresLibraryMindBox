namespace FiguresLibraryMindBox
{
    public class Triangle : Figure
    {
        private double aSide;
        private double bSide;
        private double cSide;
        private double area;

        /// <summary>
        /// Конструктор для создания объекта треугольника
        /// Дополнительно проверяется прямоугольность треугольника
        /// </summary>
        /// <param name="aSide">Первая сторона треугольника</param>
        /// <param name="bSide">Вторая сторона треугольника</param>
        /// <param name="cSide">Третья сторона треугольника</param>
        public Triangle(double aSide, double bSide, double cSide)
        {
            this.aSide = aSide;
            this.bSide = bSide;
            this.cSide = cSide;

            if (Math.Pow(aSide,2) + Math.Pow(bSide,2) == Math.Pow(cSide, 2))
            {
                Console.WriteLine("Triangle is rectangular!");
            }
        }

        /// <summary>
        /// Вычисляет периметр треугольника
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return aSide + bSide + cSide;
        }
        
        /// <summary>
        /// Вычисляет площадь треугольника по формуле Герона
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            double halfMeter = GetPerimeter() / 2;
            area = Math.Sqrt(halfMeter * (halfMeter - aSide) * (halfMeter - bSide) * (halfMeter - cSide));
            return area;
        }
    }
}
