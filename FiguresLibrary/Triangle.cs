namespace FiguresLibrary
{
    public class Triangle:Figure
    {
        public double aSide { get; set; }
        public double bSide { get; set; }
        public double cSide { get; set; }
        public Triangle(double a, double b, double c)
        {
            aSide = a;
            bSide = b;
            cSide = c;
            if (aSide * aSide + bSide * bSide == cSide * cSide)
                Console.WriteLine("Данный треугольник прямоугольный.");
        }
        public override double GetArea()
        {
            if (Exist())
            {
                double p = GetPerimeter() / 2;
                Area = Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));
                return Area;
            }
            else
                return 0;
        }
        public override double GetPerimeter()
        {
            if (Exist())
            {
                Perimeter = aSide + bSide + cSide;
                return Perimeter;
            }
            else
                return 0;
        }
        public bool Exist()
        {
            if (((aSide + bSide) > cSide) && ((aSide + cSide) > bSide) && ((bSide + cSide) > aSide) && (aSide > 0) && (bSide > 0) && (cSide > 0))
                return true;
            else
                return false;
        }
    }
}
